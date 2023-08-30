--База података: ------------------------------------------------------------------------------------------
CREATE DATABASE Fakultetska_baza_podataka;
USE Fakultetska_baza_podataka;

--Табеле: -------------------------------------------------------------------------------------------------
CREATE TABLE Predmet(
  id INT PRIMARY KEY,
  naziv NVARCHAR(100) NOT NULL,
  godina INT NOT NULL,
  semestar INT NOT NULL,
  poruka NVARCHAR(500),
  espb INT NOT NULL,
  tezina INT
);

INSERT INTO Predmet VALUES (1, N'Алгоритми и структуре података', 2, 1, NULL, 6, 3);
INSERT INTO Predmet VALUES (2, N'Нумеричка анализа и дискретна математика', 2, 1, NULL, 6, 1);
INSERT INTO Predmet VALUES (3, N'Објектно оријентисано програмирање', 2, 1, NULL, 6, 2);

SELECT *
FROM Predmet;


CREATE TABLE Sesija(
  id INT PRIMARY KEY,
  fk_predmet INT FOREIGN KEY REFERENCES Predmet(id),
  datum DATE,
  vreme_pocetka TIME,
  vreme_zavrsetka TIME,
  ukupno_vreme TIME,
  efektivno_vreme TIME,
  efikasnost DECIMAL(5, 2),
  poruka NVARCHAR(500)
);

INSERT INTO Sesija VALUES (1, 3, '2023-10-05', '14:30', '16:00', '1:30', '1:00', 66.67, NULL);
INSERT INTO Sesija VALUES (2, 2, '2023-10-05', '18:00', '20:00', '2:00', '1:40', 83.33, NULL);
INSERT INTO Sesija VALUES (3, 1, '2023-10-06', '09:00', '09:30', '0:30', '0:30', 100.00, NULL);

SELECT efikasnost
FROM Sesija
WHERE id = 1;