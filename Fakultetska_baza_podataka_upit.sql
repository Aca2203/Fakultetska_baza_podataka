--База података: -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE DATABASE Fakultetska_baza_podataka;
USE Fakultetska_baza_podataka;

CREATE DATABASE Pomocna;
USE Pomocna;

DROP DATABASE Fakultetska_baza_podataka;

--Функције: ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE FUNCTION efikasnost_sesije(@ukupno_vreme TIME, @efektivno_vreme TIME)
RETURNS DECIMAL (5, 2)
AS
BEGIN
  IF (@ukupno_vreme IS NULL) OR (@efektivno_vreme IS NULL) RETURN NULL
  ELSE
  BEGIN
    DECLARE @ukupno_minuta INT = DATEDIFF(MINUTE, 0, @ukupno_vreme);
	DECLARE @efektivno_minuta INT = DATEDIFF(MINUTE, 0, @efektivno_vreme);
	RETURN CAST(@efektivno_minuta AS DECIMAL) / CAST(@ukupno_minuta AS DECIMAL) * 100;
  END;
  RETURN NULL;
END;

--Табеле: ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE Predmet(
  id INT PRIMARY KEY IDENTITY (1, 1),
  naziv NVARCHAR(100) NOT NULL,
  godina INT NOT NULL,
  semestar INT NOT NULL,
  poruka NVARCHAR(500),
  espb INT NOT NULL,
  tezina INT
);

INSERT INTO Predmet VALUES (N'Алгоритми и структуре података', 2, 1, NULL, 6, 3);
INSERT INTO Predmet VALUES (N'Нумеричка анализа и дискретна математика', 2, 1, NULL, 6, 1);
INSERT INTO Predmet VALUES (N'Објектно оријентисано програмирање', 2, 1, NULL, 6, 2);
INSERT INTO Predmet VALUES (N'Физика 1', 1, 1, NULL, 6, 2);

SELECT *
FROM Predmet;



CREATE TABLE Sesija(
  id INT PRIMARY KEY IDENTITY (1, 1),
  fk_predmet INT FOREIGN KEY REFERENCES Predmet(id),
  datum DATE,
  vreme_pocetka TIME,
  vreme_zavrsetka TIME,
  ukupno_vreme TIME,
  efektivno_vreme TIME,
  efikasnost AS dbo.efikasnost_sesije(ukupno_vreme, efektivno_vreme),
  poruka NVARCHAR(500)
);

INSERT INTO Sesija VALUES (3, '2023-10-05', '14:30', '16:00', '1:30', '1:00', NULL);
INSERT INTO Sesija VALUES (2, '2023-10-05', '18:00', '20:00', '2:00', '1:40', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', '0:30', '0:30', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', '0:30', NULL, NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', NULL, '0:30', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', NULL, NULL, NULL);
INSERT INTO Sesija VALUES (1, '2023-10-27', '11:00', '11:30', '0:30', '0:20', NULL);

SELECT *
FROM Sesija;


-- Пример приказа
SELECT Sesija.id AS 'ID сесије', Predmet.naziv AS 'Назив предмета', datum AS 'Датум сесије', vreme_pocetka AS 'Време почетка', vreme_zavrsetka AS 'Време завршетка', ukupno_vreme AS 'Укупно време', efektivno_vreme AS 'Ефективно време', efikasnost AS 'Ефикасност'
FROM Sesija
JOIN Predmet ON Predmet.id = Sesija.fk_predmet;

-- Процедуре: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE Predmet_Insert
@naziv NVARCHAR(100),
@godina INT,
@semestar INT,
@espb INT
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  IF EXISTS(SELECT TOP 1 naziv FROM Predmet
  WHERE naziv = @naziv)
  RETURN -1
  ELSE
    INSERT INTO Predmet (naziv, godina, semestar, poruka, espb, tezina) VALUES (@naziv, @godina, @semestar, NULL, @espb, NULL)
	RETURN 0;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC Predmet_Insert @naziv = N'Физика 1', @godina = 1, @semestar = 1, @espb = 6;
EXEC Predmet_Insert @naziv = N'Физика 1', @godina = 1, @semestar = 1, @espb = 6;



CREATE PROCEDURE Predmet_Update
@naziv NVARCHAR(100),
@godina INT,
@semestar INT,
@poruka NVARCHAR(500),
@espb INT,
@tezina INT
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  IF EXISTS(SELECT TOP 1 naziv FROM Predmet
  WHERE naziv = @naziv)
  BEGIN
    UPDATE Predmet SET godina = @godina, semestar = @semestar, poruka = @poruka, espb = @espb, tezina = @tezina WHERE naziv = @naziv
	RETURN 0;
  END;
  RETURN -1;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC Predmet_Update @naziv = N'Физика 1', @godina = 3, @semestar = 2, @poruka = N'Здраво!', @espb = 3, @tezina = 3;
EXEC Predmet_Update @naziv = N'Математика 1', @godina = 3, @semestar = 2, @poruka = N'Здраво!', @espb = 3, @tezina = 3;



CREATE PROCEDURE Predmet_Delete
@naziv NVARCHAR(100)
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  IF EXISTS(SELECT TOP 1 naziv FROM Predmet
  WHERE naziv = @naziv)
  BEGIN
    DELETE FROM Predmet WHERE naziv = @naziv;
	RETURN 0;
  END;
  RETURN -1;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC Predmet_Delete @naziv = N'Физика 1';



CREATE PROCEDURE Sesija_Insert
@fk_predmet INT,
@datum DATE,
@vreme_pocetka TIME,
@vreme_zavrsetka TIME,
@ukupno_vreme TIME,
@efektivno_vreme TIME,
@poruka NVARCHAR(500)
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  INSERT INTO Sesija (fk_predmet, datum, vreme_pocetka, vreme_zavrsetka, ukupno_vreme, efektivno_vreme, poruka) VALUES (@fk_predmet, @datum, @vreme_pocetka, @vreme_zavrsetka, @ukupno_vreme, @efektivno_vreme, @poruka)
  RETURN 0;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC Sesija_Insert @fk_predmet = 2, @datum = '2023-08-31', @vreme_pocetka = '17:30', @vreme_zavrsetka = '18:30', @ukupno_vreme = '1:00', @efektivno_vreme = '0:40', @poruka = N'Ово је порука.';



CREATE PROCEDURE Sesija_Update
@id INT,
@fk_predmet INT,
@datum DATE,
@vreme_pocetka TIME,
@vreme_zavrsetka TIME,
@ukupno_vreme TIME,
@efektivno_vreme TIME,
@poruka NVARCHAR(500)
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  IF EXISTS(SELECT TOP 1 id FROM Sesija
  WHERE id = @id)
  BEGIN
    UPDATE Sesija SET fk_predmet = @fk_predmet, datum = @datum, vreme_pocetka = @vreme_pocetka, vreme_zavrsetka = @vreme_zavrsetka, ukupno_vreme = @ukupno_vreme, efektivno_vreme = @efektivno_vreme, poruka = @poruka WHERE id = @id
	RETURN 0;
  END;
  RETURN -1;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC Sesija_Update @id = 7, @fk_predmet = 3, @datum = '2023-08-29', @vreme_pocetka = '16:30', @vreme_zavrsetka = '19:30', @ukupno_vreme = '3:00', @efektivno_vreme = '2:40', @poruka = N'Ово је порука!';
EXEC Sesija_Update @id = 50, @fk_predmet = 3, @datum = '2023-08-29', @vreme_pocetka = '16:30', @vreme_zavrsetka = '19:30', @ukupno_vreme = '3:00', @efektivno_vreme = '2:40', @poruka = N'Ово је порука!';



CREATE PROCEDURE Sesija_Delete
@id INT
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  IF EXISTS(SELECT TOP 1 id FROM Sesija
  WHERE id = @id)
  BEGIN
    DELETE FROM Sesija WHERE id = @id;
	RETURN 0;
  END;
  RETURN -1;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC Sesija_Delete @id = 7;