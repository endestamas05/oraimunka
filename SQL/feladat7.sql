/*1. Feladat*/
CREATE DATABASE ZENETAR
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE CD(
    id INT NOT NULL PRIMARY KEY,
    elado VARCHAR(100),
    cim VARCHAR(100),
    hossz INT DEFAULT(45),
    hallgathato BOOLEAN
);

/*2. Feladat*/
CREATE DATABASE TANKER
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE TANKER(
    id INT AUTO_INCREMENT  PRIMARY KEY,
    nev VARCHAR(50),
    telepules VARCHAR(50) DEFAULT('Budapest'),
    cim VARCHAR(50),
    belepes DATE,
    kilepes DATE DEFAULT()
);

/*3. Feladat*/
CREATE DATABASE LAKAS
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE BUTOR(
    termek_neve VARCHAR(50) UNIQUE,
    cikkszam VARCHAR(10) PRIMARY KEY,
    mennyiseg INT,
    egysegar DOUBLE(4,2)
);