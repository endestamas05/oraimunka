CREATE DATABASE konyvek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE konyvek(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    cim VARCHAR(100) NOT NULL,
    szerzo VARCHAR(50) NOT NULL,
    oldal_szam INT,
    ar INT,
    kategoria VARCHAR(50)
);

INSERT INTO konyvek(cim,szerzo,oldal_szam,ar,kategoria) VALUES
    ("Vinettu és az ezüsttó kincse","Karl Maj",231,6000,"kaland"),
    ("13 almafa","Wass Albert",167,4500,"történelmi"),
    ("Star Wars","Hajdu László",895,7000,"romantikus"),
    ("Terminátor", "Sinkó István",232,6500,"akció")

SELECT cim AS "Cím", szerzo AS "Szerző"
FROM konyvek
ORDER BY ar DESC
LIMIT 3;

SELECT COUNT(kategoria) AS "Romantikus könyvek"
FROM konyvek
WHERE kategoria = "romantikus";

SELECT COUNT(id) AS "Könvek száma"
FROM konyvek;

SELECT AVG(ar) AS "Átlagár"
FROM konyvek;

SELECT AVG(oldal_szam) AS "Átlag oldalszám"
FROM konyvek;

SELECT *
FROM konyvek
WHERE oldal_szam > 700;