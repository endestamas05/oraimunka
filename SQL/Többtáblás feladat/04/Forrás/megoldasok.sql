-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
CREATE DATABASE nagykonyv
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

-- 3. feladat:
SELECT nemzetiseg
FROM szerzo
WHERE nemzetiseg NOT LIKE 'magyar'
GROUP BY nemzetiseg;

-- 4. feladat:
SELECT nev, 2005-szulEv AS 'kor'
FROM szerzo
WHERE halEv IS NULL;

-- 5. feladat:
SELECT nev, MIN(helyezes) AS 'legjobb'
FROM
    konyv INNER JOIN szerzo ON konyv.szerzoID=szerzo.id
WHERE nemzetiseg LIKE 'magyar';
GROUP BY nev
ORDER BY legjobb ASC;

-- 6. feladat:
SELECT nev, COUNT(cim) AS 'konyvek'
FROM
    konyv INNER JOIN szerzo ON konyv.szerzoID=szerzo.id
GROUP BY nev
HAVING COUNT(cim) > 1
ORDER BY konyvek DESC;