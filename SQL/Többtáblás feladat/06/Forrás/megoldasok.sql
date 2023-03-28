-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 8. feladat:
CREATE DATABASE konyvtarak
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungaryan_ci;

-- 10. feladat:
UPDATE megyek
SET megyeNev = 'Budapest'
WHERE megyeNev LIKE 'BP';


-- 11. feladat:
SELECT konyvtarNev, irsz
FROM konyvtarak;

-- 12. feladat:
SELECT konyvtarNev, irsz, cim
FROM konyvtarak
WHERE irsz LIKE "1%";

-- 13. feladat:
SELECT telepulesek.telepNev, COUNT(konyvtarak.konyvtarNev) AS "konyvtarDarab"
FROM
    konyvtarak INNER JOIN telepulesek ON konyvtarak.irsz=telepulesek.irsz
GROUP BY telepNev
HAVING COUNT(konyvtarak.konyvtarNev) >= 7;

-- 14. feladat:
SELECT megyek.megyeNev, COUNT(megyek.id)
FROM
    megyek INNER JOIN telepulesek ON megyek.id=telepulesek.megyeId
WHERE telepulesek.irsz NOT LIKE "1%"
GROUP BY megyek.megyeNev
ORDER BY COUNT(megyek.id) DESC;