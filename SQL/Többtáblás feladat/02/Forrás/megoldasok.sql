A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:
CREATE DATABASE teke
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

3. feladat:
SELECT nev AS "Név"
FROM versenyzok
WHERE korcsop LIKE "A"
ORDER BY nev ASC;

4. feladat:
SELECT DISTINCT versenyzo
FROM eredmenyek
WHERE ures > 0;

/*
VAGY

SELECT versenyzo
FROM eredmenyek
WHERE ures > 0;
GROUP BY versenyzo;
*/

5. feladat:
SELECT versenyzok.nev, AVG(eredmenyek.tarolas) AS "atlagpont"
FROM
    versenyzok INNER JOIN eredmenyek ON versenyzok.rajtszam = eredmenyek.versenyzo
GROUP BY nev
ORDER BY atlagpont DESC;

6. feladat:
SELECT egyesuletek.nev
FROM
    egyesuletek INNER JOIN versenyzok ON egyesuletek.id = versenyzok.egyid
GROUP BY egyesuletek.id
ORDER BY COUNT(rajtszam) DESC
LIMIT 1;

7. feladat:
SELECT nev, SUM(teli + tarolas) AS "eredmeny", SUM(tarolas) AS "tarolas", SUM(ures) AS "ures"
FROM
    versenyzok INNER JOIN eredmenyek ON versenyzok.rajtszam = eredmenyek.versenyzo
WHERE korcsop LIKE "B"
GROUP BY nev
ORDER BY eredmeny DESC, SUM(tarolas) DESC, SUM(ures) ASC;