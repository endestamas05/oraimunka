/*Komment*/

/*1. Feladat: Hozzon létre egy adatbázist. Állítsa be a kódolást és a rendezési sorrendet a magyar ábécének megfelelően*/
CREATE DATABASE iskola
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

/*2. Feladat: Hozzon létre táblát osztzály néven. A táblában a tárolt adatok a következők:
    id - egész, automatikusan kapjon értéket, ez az elsődleges kulcs
    név - szöveg (max 120 karakter)
    osztály - egész
    átlag - valós
Állítsa be mindegyik mezőre, hogy ne lehessen NULL érték*/
CREATE TABLE osztaly(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nev VARCHAR(120) NOT NULL,
    osztaly INT NOT NULL,
    atlag DOUBLE NOT NULL
);

/*3. Feladat: Szurjon be 4 adatot az osztály táblába.*/
INSERT INTO osztaly(nev, osztaly, atlag)
VALUES('Random 1', 11, 1.1);

INSERT INTO osztaly(nev, osztaly, atlag) VALUES
('Random 2', 11, 1),
('Víz Elek', 11, 5),
('Füty Imre', 11, 2);

/*4. Feladat: Jelenítsen meg mindent.*/
SELECT id AS'Azonosító', nev, osztaly AS'Osztály', atlag
FROM osztaly;

SELECT *
FROM osztaly;

/*5. Feladat: Írja ki azoknak a nevét és osztályát, akik, nem állnak bukásra.*/
SELECT nev AS'Név', osztaly AS 'Osztály'
FROM osztaly
WHERE atlag >= 2;

/*6. Feladat: Írja ki, hogy hány adatot tárolunk az osztály táblában.*/
SELECT COUNT(id) AS'Adatok darabszáma:'
FROM osztaly;

/*7. Feladat Készítsen lekérdezést, amely megadja az osztályátlagát.*/
SELECT AVG(atlag) AS'Átlag:'
FROM osztaly
GROUP BY osztaly.osztaly;

/*
Józsi - 10 - 1
Márta - 11 - 2
Fecó - 10 - 1
Jázmin - 9 - 5

GROUP BY osztaly.osztaly =>
 10.: Fecó - 10 - 1, Józsi - 10 - 1 => 1
 11.: Márta - 11 - 2 => 2
 9.: Jázmin - 9 - 5 => 5
*/
/*8. Feladat dobd el az iskola adatbázist.*/
DROP DATABASE iskola;