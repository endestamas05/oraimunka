-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 10. feladat:
CREATE DATABASE tisza
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

-- 12. feladat:
DELETE FROM meres
WHERE nap LIKE "2020-03-27";

-- 13. feladat:
UPDATE vizmerce
SET igID = 2
WHERE varos LIKE "Tokaj";

-- 14. feladat:
SELECT varos, nullPont
FROM vizmerce
ORDER BY nullPont ASC
LIMIT 1;

-- 15. feladat:
SELECT varos, Lnv-Lkv AS "ingadozas"
FROM vizmerce
GROUP BY varos
ORDER BY ingadozas DESC;
 
-- 16. feladat:
SELECT igazgatosag.nev, COUNT(vizmerce.id) AS "merceszam"
FROM
    igazgatosag INNER JOIN vizmerce ON igazgatosag.id=vizmerce.igID
GROUP BY igazgatosag.nev;
  
-- 17. feladat:
SELECT AVG(meres.vizAllas) AS "atlag"
FROM
    meres INNER JOIN vizmerce ON meres.vmId=vizmerce.id
WHERE vizmerce.varos LIKE "Szolnok" AND meres.nap LIKE "2020-04-%";

