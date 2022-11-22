/*1. Feladat*/
CREATE DATABASE autokerdb
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE autok(
    rendszam VARCHAR(6) PRIMARY KEY NOT NULL,
    tipus VARCHAR(10),
    fogyasztas DOUBLE(3,1),
    megtett_ut INT
);

INSERT INTO autokkerdb(rendszam,tipus,fogyasztas,megtett_ut) VALUES
    ("GEO323","SKODA",9.7,100231),
    ("OSI127","LADA",8.1,53276),
    ("BOD321","FIAT",6.3,62346),
    ("HAJ476","FORD",7.2,15362),
    ("GAZ912","FIAT",6.6,123234),
    ("JEU764","VOLVO",10.5,65387);

UPDATE autok
SET fogyasztas=6.5
WHERE rendszam LIKE "BOD321";

UPDATE autok
SET megtett_ut=megtett_ut*2
WHERE rendszam LIKE "GAZ912";

UPDATE autok
SET fogyasztas=fogyasztas*1.1
WHERE tipus LIKE "FIAT";

DELETE FROM autok WHERE tipus LIKE "LADA";

DELETE FROM autok WHERE megtett_ut>100000;

/*2. Feladat*/
CREATE DATABASE emberdb
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE ember(
    szemig_szam VARCHAR(8) PRIMARY KEY NOT NULL,
    nev VARCHAR(30),
    szuletesiido DATE,
    testmagassag INT(3),
    testsuly INT(3)
);

INSERT INTO ember(szemig_szam,nev,szuletesiido,testmagassag,testsuly) VALUES
    ("AJ344523","Mander Endre",'1954.11.11',185,95),
    ("BA203031","Bálint Imre",'1972.08.12',177,70),
    ("AF173542","Tóth Miksa",'1976.01.23',180,78),
    ("ZE871261","Hegedüs Erna",'1980.04.13',167,58),
    ("FG425613","Murányi Ella",'1977.12.20',165,55),
    ("AI521721","Szenthy Kálmán",'1938.09.27',172,85);

UPDATE ember
SET testsuly=testsuly-5
WHERE szemig_szam LIKE "FG425613";

UPDATE ember
SET testmagassag=180, testsuly=73
WHERE szemig_szam LIKE "BA203031";

UPDATE ember
SET nev="Murányi Emma"
WHERE szemig_szam LIKE "FG425613";

DELETE FROM ember WHERE testmagassag=180
OR nev LIKE"Szenthy Kálmán"
OR szuletesiido LIKE '1954.11.11'

/*3. Feladat*/
CREATE DATABASE erettDb
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE vizsga(
    Azonosito INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    Nev VARCHAR(30) NOT NULL,
    Targy VARCHAR(50) NOT NULL,
    Jegy INT(1) DEFAULT(5) NOT NULL,
    Szint VARCHAR(30) DEFAULT('Középszint') NOT NULL
);

INSERT INTO vizsga(Nev,Targy,Jegy,Szint) VALUES
    ("Kovács István","történelem",3,"Emelt szint"),
    ("Kis Sándor","informatika",4,"Középszint"),
    ("Kis Sára","matematika",1,"Emelt szint"),
    ("Nagy Péter","informatika",2,"Középszint"),
    ("Tóth József","angol nyelv",5,"Középszint"),
    ("Szabó Miklós","magyar nyelv és irodalom",4,"Középszint"),
    ("Kovács Antal","matematika",5,"Emelt szint"),
    ("Szántó Pél","informatika",4,"Emelt szint"),
    ("Molnár Mária","történelem",4,"Középszint"),
    ("Varga Vendel","matematika",1,"Középszint");

UPDATE vizsga
SET Nev="Szántó Pál"
WHERE Nev LIKE "Szántó Pél";

UPDATE vizsga
SET Szint="Emelt szint"
WHERE Nev LIKE "Kis Sándor";

UPDATE vizsga
SET Jegy=5, Szint="Emelt szint"
WHERE Azonosito LIKE 4;

DELETE FROM vizsga WHERE Jegy LIKE 1;

DELETE FROM vizsga WHERE Szint LIKE "Középszint";

DELETE FROM vizsga WHERE JEGY LIKE 5
AND Szint LIKE "Emelt szint";

/*4. Feladat*/
CREATE DATABASE atletika
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE sportolo(
    Nev VARCHAR(50) PRIMARY KEY NOT NULL,
    Nem VARCHAR(10),
    Versenyszam VARCHAR(50),
    Egyesulet VARCHAR(10) NOT NULL
);

INSERT INTO sportolo(Nev,Nem,Versenyszam,Egyesulet) VALUES
    ("Arnold Jenő","férfi","magasugrás","BSE"),
    ("Melisch Mónika","nő","távolugrás","BSE"),
    ("Porkoláb Richárd","férfi","rúdugrás",NULL),
    ("Gubis Ábris",NULL,"5000 m síkfutás","UTE"),
    ("Bene Flőra","nő","800 m síkfutás","FTC"),
    ("Szlovák Anikó","nő","rúdugrás","MTK");

UPDATE sportolo
SET nev="Bene Flóra"
WHERE nev LIKE "Bene Flőra";

DELETE FROM sportolo WHERE Egyesulet LIKE "";

UPDATE sportolo
SET Egyesulet="MTK"
WHERE Egyesulet LIKE "BSE";

/*5. Feladat*/
CREATE DATABASE dolgozokdb
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE SzemAdat(
    Nev VARCHAR(30) PRIMARY KEY,
    Szuletesi_ev INT(4),
    Iranyitoszam INT(4),
    Lakhey VARCHAR(30) DEFAULT("Budapest"),
    Havi_jovedelem INT(8)
);

INSERT INTO SzemAdat(Nev,Szuletesi_ev,Iranyitoszam,Lakhey,Havi_jovedelem) VALUES
    ("Cseke Zsuzsa",1979,1181,"Budapest",23953),
    ("Cseke Etelka",1968,8360,"Keszthely",54400),
    ("Lakatos Katalin",1968,9021,"Győr",75416),
    ("Esterházy Pál",1967,8600,"Siófok",53909),
    ("Cseh Katalin",1965,4400,"Nyíregyháza",70781),
    ("Holló Hedvig",1957,9730,"Kőszeg",46362),
    ("Faragó Etelka",1951,1234,"Budapest",56974);

UPDATE SzemAdat
SET Havi_jovedelem=Havi_jovedelem+100000;

UPDATE SzemAdat
SET Havi_jovedelem=Havi_jovedelem*0.9;

UPDATE SzemAdat
SET Iranyitoszam=1191, Lakhey="Budapest"
WHERE Nev LIKE "Cseke Etelka";

DELETE FROM SzemAdat WHERE Szuletesi_ev LIKE 1968;

DELETE FROM SzemAdat WHERE Lakhey LIKE "Budapest";