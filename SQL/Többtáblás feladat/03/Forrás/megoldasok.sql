A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:
CREATE DATABASE maratonvalto
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

3. feladat:
INSERT INTO eredmenyek (futo, kor, ido)
VALUES (1044, 4, 15765);

4. feladat:
SELECT fnev AS 'fuoto', szulev
FROM futok
WHERE ffi = 0
ORDER BY fnev ASC;

5. feladat:
SELECT fnev AS 'futo', 2016-szulev AS 'kor'
FROM futok
ORDER BY 2016-szulev DESC, szulho DESC;

6. feladat:
SELECT fnev AS 'futo', ido
FROM
    futok INNER JOIN eredmenyek ON futok.fid=eredmenyek.futo
ORDER BY ido ASC
LIMIT 10;

7. feladat:
SELECT csapat, SUM(ido) AS 'csapatido'
FROM
    futok INNER JOIN eredmenyek ON futok.fid=eredmenyek.futo
GROUP BY csapat
ORDER BY csapatido ASC;