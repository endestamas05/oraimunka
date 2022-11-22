/* a. Feladat */
CREATE DATABASE telefonok
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

/* b. Feladat */
CREATE TABLE telefon(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    marka VARCHAR(30),
    ar INT,
    meret DOUBLE,
    szin VARCHAR(30)
);

/* c. Feladat */
INSERT INTO telefon(marka,ar,meret,szin) VALUES
("Samsung",128000,6.5,'fekete'),
("Xiaomi",45000,8,'sárga'),
("Apple",840000,5.8,'kék'),
("Huawei",60000,7,'szürke');

/* d. Feladat */
SELECT marka AS 'márka', ar AS 'ár'
FROM telefon
ORDER BY ar DESC
LIMIT 1;

/* e. Feladat */
SELECT AVG(ar) AS 'átlag ár'
FROM telefon
WHERE szin LIKE 'szürke';

/* f. Feladat */
SELECT kijelzo AS 'kijelző mérete'
FROM telefon
WHERE szin LIKE 'fekete'
ORDER BY meret DESC
LIMIT 1;

/* g. Feladat */
SELECT id, marka AS 'Márka'
FROM telefon
WHERE ar > 400000;

/* h. Feladat */
SELECT *
FROM telefon
ORDER BY ar ASC
LIMIT 1;

/* i. Feladat */
SELECT id, marka AS 'márka'
FROM telefon
WHERE szin 'kék' and meret = 5.8;