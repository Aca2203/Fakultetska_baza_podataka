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
  IF ((@ukupno_vreme = '00:00:00') AND (@efektivno_vreme = '00:00:00')) OR ((@ukupno_vreme IS NULL) AND (@efektivno_vreme IS NULL)) RETURN 0
  ELSE
  IF (@ukupno_vreme = '00:00:00') OR (@efektivno_vreme = '00:00:00') RETURN NULL
  ELSE
  BEGIN
    DECLARE @ukupno_minuta INT = DATEDIFF(MINUTE, 0, @ukupno_vreme);
	DECLARE @efektivno_minuta INT = DATEDIFF(MINUTE, 0, @efektivno_vreme);
	RETURN CAST(@efektivno_minuta AS DECIMAL) / CAST(@ukupno_minuta AS DECIMAL) * 100;
  END;
  RETURN 0;
END;

drop function efikasnost_sesije

CREATE FUNCTION efikasnost(@ukupno_vreme VARCHAR(5), @efektivno_vreme VARCHAR(5))
RETURNS DECIMAL (5, 2)
AS
BEGIN
  IF (@ukupno_vreme = '00:00') AND (@efektivno_vreme = '00:00') RETURN NULL
  ELSE
  IF (@ukupno_vreme = '00:00') OR (@efektivno_vreme = '00:00') RETURN NULL
  ELSE
  BEGIN
    DECLARE @ukupno_minuta INT = CAST(LEFT(@ukupno_vreme, 2) AS INT) * 60 + CAST(RIGHT(@ukupno_vreme, 2) AS INT);
	DECLARE @efektivno_minuta INT = CAST(LEFT(@efektivno_vreme, 2) AS INT) * 60 + CAST(RIGHT(@efektivno_vreme, 2) AS INT);
	RETURN CAST(@efektivno_minuta AS DECIMAL) / CAST(@ukupno_minuta AS DECIMAL) * 100;
  END;
  RETURN NULL;
END;

CREATE FUNCTION sati_u_minute(@vreme TIME)
RETURNS INT
AS
BEGIN
  RETURN DATEDIFF(MINUTE, 0, @vreme);
END;

CREATE FUNCTION minuti_u_sate(@minuti INT)
RETURNS VARCHAR(5)
AS
BEGIN
  DECLARE @vreme VARCHAR(5);
  IF(@minuti - (@minuti / 60) * 60 < 10) SET @vreme = CAST(@minuti / 60 AS VARCHAR(2)) + ':0' + CAST(@minuti - (@minuti / 60) * 60 AS VARCHAR(2))
  ELSE SET @vreme = CAST(@minuti / 60 AS VARCHAR(2)) + ':' + CAST(@minuti - (@minuti / 60) * 60 AS VARCHAR(2));
  RETURN @vreme
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

SELECT id AS 'ID предмета', naziv AS 'Назив предмета', godina AS 'Година', semestar AS 'Семестар', poruka AS 'Порука', espb AS 'Еспб', tezina AS 'Тежина' FROM Predmet


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

drop table sesija

select *
into Sesija
from sesija_kopija;

select *
from Sesija

alter table Sesija
add efikasnost AS dbo.efikasnost_sesije(ukupno_vreme, efektivno_vreme)

INSERT INTO Sesija VALUES (3, '2023-10-05', '14:30', '16:00', '1:30', '1:00', NULL);
INSERT INTO Sesija VALUES (2, '2023-10-05', '18:00', '20:00', '2:00', '1:40', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', '0:30', '0:30', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', '0:30', NULL, NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', NULL, '0:30', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-06', '09:00', '09:30', NULL, NULL, NULL);
INSERT INTO Sesija VALUES (1, '2023-10-27', '11:00', '11:30', '0:30', '0:20', NULL);
INSERT INTO Sesija VALUES (1, '2023-10-27', '9:00', '9:30', '0:30', '0:20', NULL);

SELECT *
FROM Sesija;


CREATE TABLE Datum(
  datum DATE PRIMARY KEY
);
INSERT INTO Datum VALUES('2023-09-01');
INSERT INTO Datum VALUES('2023-09-02');
INSERT INTO Datum VALUES('2023-09-03');
INSERT INTO Datum VALUES('2023-09-04');
INSERT INTO Datum VALUES('2023-09-05');
INSERT INTO Datum VALUES('2023-09-06');
INSERT INTO Datum VALUES('2023-09-07');
INSERT INTO Datum VALUES('2023-09-08');
INSERT INTO Datum VALUES('2023-09-09');
INSERT INTO Datum VALUES('2023-09-10');
INSERT INTO Datum VALUES('2023-09-11');
INSERT INTO Datum VALUES('2023-09-12');
INSERT INTO Datum VALUES('2023-09-13');
INSERT INTO Datum VALUES('2023-09-14');
INSERT INTO Datum VALUES('2023-09-15');
INSERT INTO Datum VALUES('2023-09-16');
INSERT INTO Datum VALUES('2023-09-17');
INSERT INTO Datum VALUES('2023-09-18');
INSERT INTO Datum VALUES('2023-09-19');
INSERT INTO Datum VALUES('2023-09-20');
INSERT INTO Datum VALUES('2023-09-21');
INSERT INTO Datum VALUES('2023-09-22');
INSERT INTO Datum VALUES('2023-09-23');
INSERT INTO Datum VALUES('2023-09-24');
INSERT INTO Datum VALUES('2023-09-25');

SELECT *
FROM Datum;

-- Пример приказа
SELECT Sesija.id AS 'ID сесије', datum AS 'Датум сесије', Predmet.naziv AS 'Назив предмета', vreme_pocetka AS 'Време почетка', vreme_zavrsetka AS 'Време завршетка', ukupno_vreme AS 'Укупно време', efektivno_vreme AS 'Ефективно време', efikasnost AS 'Ефикасност', Sesija.poruka AS 'Порука'
FROM Sesija
JOIN Predmet ON Predmet.id = Sesija.fk_predmet
ORDER BY datum DESC, vreme_pocetka DESC;

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
    INSERT INTO Predmet (naziv, godina, semestar, poruka, espb, tezina) VALUES (@naziv, @godina, @semestar, NULL, @espb, NULL);		
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



ALTER PROCEDURE prikaz_po_predmetima
@id INT
AS
BEGIN TRY
  SELECT *
  INTO Pomocna_tabela
  FROM Sesija
  WHERE Sesija.fk_predmet = @id;
  SELECT CONVERT(VARCHAR, Datum.datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Pomocna_tabela.ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Pomocna_tabela.efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Pomocna_tabela.ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Pomocna_tabela.efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Datum LEFT JOIN Pomocna_tabela ON Datum.datum = Pomocna_tabela.datum WHERE Datum.datum >= DATEADD(DAY, -20, CAST(GETDATE() AS DATE)) AND Datum.datum <= CAST(GETDATE() AS DATE) GROUP BY Datum.datum;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

EXEC prikaz_po_predmetima @id = 36;
drop table Pomocna_tabela;

-- Окидачи
CREATE TRIGGER promena_poruke
ON Sesija
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @fk_predmet INT;
  IF(EXISTS(SELECT * FROM inserted))
  BEGIN
    DECLARE @poruka NVARCHAR(500);
    SET @poruka = (SELECT poruka FROM inserted);
    SET @fk_predmet = (SELECT fk_predmet FROM inserted);
    UPDATE Predmet
    SET poruka = @poruka
    WHERE id = @fk_predmet;
  END
  ELSE
  BEGIN
    SET @fk_predmet = (SELECT fk_predmet FROM deleted);
	UPDATE Predmet
	SET poruka = ''
	WHERE id = @fk_predmet;
  END;
END;

-- Примери:
SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + CAST(CAST((SUM(dbo.sati_u_minute(efektivno_vreme)) * 100.00) / SUM(dbo.sati_u_minute(ukupno_vreme)) AS DECIMAL(5, 2)) AS VARCHAR) + '%' AS 'Датум и ефикасност', dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS 'Укупно време', dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS 'Ефективно време' FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;
SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + CAST(CAST((SUM(dbo.sati_u_minute(efektivno_vreme)) * 100.00) / SUM(dbo.sati_u_minute(ukupno_vreme)) AS DECIMAL(5, 2)) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;
SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + CAST(CAST((SUM(dbo.sati_u_minute(efektivno_vreme)) * 100.00) / SUM(dbo.sati_u_minute(ukupno_vreme)) AS DECIMAL(5, 2)) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;
SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;
SELECT CAST(SUM(dbo.sati_u_minute(ukupno_vreme)) / 60 AS VARCHAR(2)) + ':' + CAST(SUM(dbo.sati_u_minute(ukupno_vreme)) - (SUM(dbo.sati_u_minute(ukupno_vreme)) / 60)*60 AS VARCHAR(2)) FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);
SELECT dbo.efikasnost_sesije(CAST('13:00' AS TIME), CAST('11:00' AS TIME));

SELECT CONVERT(VARCHAR, Datum.datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Predmet_9.ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Predmet_9.efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Predmet_9.ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Predmet_9.efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Datum LEFT JOIN Predmet_9 ON Datum.datum = Predmet_9.datum WHERE Datum.datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND Datum.datum <= CAST(GETDATE() AS DATE) GROUP BY Datum.datum;