A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
CREATE DATABASE varosok
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

3. feladat:
SELECT vnev AS 'Városnév'
FROM varos
WHERE vnev LIKE '%vásár%'

4. feladat:
SELECT vnev AS 'Városnév > 400km2'
FROM varos
WHERE terulet > 400
ORDER BY nepesseg DESC;

5. feladat:
SELECT vnev, nepesseg
FROM 
    varos INNER JOIN megye ON varos.megyeid = megye.id
WHERE mnev LIKE 'Fejér' AND nepesseg > 15000;

/*
FROM
    megye INNER JOIN varos ON varos.megyeid = megye.id
*/

6. feladat:
SELECT vtip AS 'Város típusa',  COUNT(varos.id) AS 'Városok száma', SUM(nepesseg) AS "Népesség"
FROM
    varos INNER JOIN varostipus ON varostipus.id = varos.vtipid
WHERE vtip <> 'Főváros'
GROUP BY vtip;

/*
WHERE vtip NOT LIKE 'Főváros'
*/

7. feladat:
SELECT mnev, Count(varos.id) AS "db"
FROM
    varos INNER JOIN megye ON varos.megyeid = megye.id
WHERE jaras <> kisterseg
GROUP BY mnev
HAVING COUNT(varos.id) > 8
ORDER BY COUNT(varos.id) DESC;