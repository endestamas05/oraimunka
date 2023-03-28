-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
CREATE DATABASE  euroskills
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

-- 3. feladat:
SELECT COUNT(nev) AS 'ermek'
FROM versenyzo
WHERE pont >= 700;

-- 4. feladat:
SELECT orszag.orszagNev
FROM 
    orszag INNER JOIN versenyzo ON orszag.id=versenyzo.orszagid
WHERE versenyzo.orszagid LIKE orszag.id
GROUP BY orszagNev
ORDER BY orszagNev ASC;

-- 5. feladat:
SELECT szakma.szakmaNev, COUNT(versenyzo.id) AS 'versenyzok szama'
FROM
    szakma INNER JOIN versenyzo ON szakma.id=versenyzo.szakmaId
GROUP BY szakmaNev
ORDER BY COUNT(versenyzo.id) DESC;

-- 6. feladat:
SELECT versenyzo.nev, orszag.orszagNev, szakma.szakmaNev, versenyzo.pont
FROM
    versenyzo INNER JOIN orszag ON versenyzo.orszagid=orszag.id 
    INNER JOIN szakma ON versenyzo.szakmaId=szakma.id
ORDER BY versenyzo.pont DESC, versenyzo.nev ASC
LIMIT 25;