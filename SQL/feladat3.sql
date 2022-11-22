/*
- Hozzon létre adatbázist emberek néven. Állítsa be a kódolást és a rendezési sorrendet a magyar ábécének megfelelően.
- Hozzon létre egy táblát ember néven. A táblában tárolt adatok a következők:
    - id - Egész szám, automatikusan kapjon értéket, ez a kulcs, nem lehet NULL értéke
    - név - Szöveg  (max 50 karakter) nem lehet NULL értéke
    - kor - egész szám
    - súly - valós szám
1. Szurjon be 5 adatot a táblába.
2. Készítsen lekérdezést, amely  mindn adatot megjelenít a táblából.
3. Készítsen lekérdezést, amely megjeleníti azoknak az embereknek a nevét, amelyben szerepel 'b' betű. => szöveget haaunlítunk, akkor a LIKE-ot használjuk. % - tetszőleges számú karaktert helyettesít nev LIKE "%" => bármilyen szöveg lehet nev LIKE "% Ferenc" => kilistáz mindenkit, akinek Ferenc a keresztneve.
4. Készítsen lekérdezét, amely megjeleníti azoknak az embereknek a nevét és a korát, akiknek a neve 'T' betűvel kezdődik.
5. Készítsen lekérdezést, amely megjeleníti azoknak az embereknek a nevét, akiknek a neve 'k' betűre végződik.
6. Készítsen lekérdezést, amely megjeleníti azoknak az embereknek a nevét, akiknek a súlya több mint 70kg.
7. Írja ki a neveket ABC sorrendben.
8. Írja ki a legkönnyebb ember nevét és korát.
*/

CREATE DATABASE emberek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE ember(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nev VARCHAR(50) NOT NULL,
    kor INT,
    suly DOUBLE
);

/* 1. Feladat */
INSERT INTO ember(nev,kor,suly) VALUES
('Ferenc József',47,73),
('Wass Albert',79,74),
('Endes Tamás',17,82),
('Szabó Álmos',18, 73),
('Endes Miklós', 89, 79);

/* 2. Feladat */
SELECT id, nev AS 'név', kor, suly AS 'súly' /* SELECT * */
FROM ember;

/* 3. Feladat */
SELECT nev AS 'név'
FROM ember
WHERE nev LIKE "%b%";

/* 4. Feladat */
SELECT nev AS 'név',kor
FROM ember
WHERE nev LIKE "T%";

/* 5. Feladat */
SELECT nev AS 'név',kor
FROM ember
WHERE nev LIKE "%k";

/* 6. Feladat */
SELECT nev AS 'név', suly AS 'súly'
FROM ember
WHERE suly >70;

/* 7. Feladat */
SELECT nev AS 'név'
FROM ember
ORDER BY nev ASC;

/* 8. Feladat */
SELECT nev AS 'név', suly AS 'súly'
FROM ember
ORDER BY suly ASC
LIMIT 1;