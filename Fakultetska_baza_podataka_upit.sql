--База података: -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE DATABASE Fakultetska_baza_podataka;
USE Fakultetska_baza_podataka;

CREATE DATABASE Pomocna;
USE Pomocna;

DROP DATABASE Fakultetska_baza_podataka;

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
  efikasnost DECIMAL(5, 2),
  poruka NVARCHAR(500)
);

INSERT INTO Sesija VALUES (3, '2023-10-05', '14:30', '16:00', '1:30', '1:00', 66.67, NULL);
INSERT INTO Sesija VALUES (2, '2023-10-05', '18:00', '20:00', '2:00', '1:40', 83.33, NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', '0:30', '0:30', 100.00, NULL);

SELECT *
FROM Sesija;

-- Пример приказа
SELECT Predmet.naziv AS 'Назив предмета', datum AS 'Датум сесије', vreme_pocetka AS 'Време почетка', vreme_zavrsetka AS 'Време завршетка', ukupno_vreme AS 'Укупно време', efektivno_vreme AS 'Ефективно време', efikasnost AS 'Ефикасност'
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

