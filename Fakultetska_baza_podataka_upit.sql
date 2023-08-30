CREATE DATABASE Fakultetska_baza_podataka;
USE Fakultetska_baza_podataka;

//----------------------------------------------
CREATE TABLE Predmet(
  id INT PRIMARY KEY,
  naziv NVARCHAR(100) NOT NULL,
  godina INT NOT NULL,
  semestar INT NOT NULL,
  istorijat NVARCHAR(50),
  
);