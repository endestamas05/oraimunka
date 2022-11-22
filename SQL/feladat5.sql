CREATE TABLE jatek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE jateoks(
    id INT AUT_INCREMENT PRIMARY KEY NOT NULL,
    jatekos_neve VARCHAR(50),
    jatekos_jeszava VARCHAR(50),
    kor - INT,
    jatekos_legjobb_pontszama INT
);

INSERT INTO jatekos(jatekos_neve,jatekos_jeszava,kor,jatekos_legjobb_pontszama) VALUES
    ("Epicgamer","kilenc9",9,120),
    ("Neymar","focibajnok",23,80),
    ("Szabó Álmos","harcművész12",18,160),
    ("Endes Tamás","fortnite",17,110),


SELECT nev AS "név", kor
FROM jatekos
GROUP BY jatekos_legjobb_pontszama DESC
LIMIT 1;

SELECT nev AS "név", jatekos_legjobb_pontszama
FROM jatekos
GROUP BY jatekos_legjobb_pontszama ASC
LIMIT 1;

SELECT id, kor
FROM jatekos
WHERE kor >= 18;

SELECT AVG(jatekos_legjobb_pontszama) AS "átlag pontszám"
FROM jateoks;

SELECT MAX(jatekos_legjobb_pontszama) AS "legnagyobb pontszám"
FROM jateoks;

SELECT SUM(jatekos_legjobb_pontszama) AS "össz pontszám"
FROM jateoks;