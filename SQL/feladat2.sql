/*1. Feladat: Hozzon létre egy adatbázist perifériák néven, állítsa be a kódolást a magyar ábécének megfelelően.

2. Feladat: Hozzon létre egy táblát monitor néven. A táblán tárolt adatok a következőek:
    -id - egész szám, automatikusan kapjon értéket, ez legyen a kulcs
    -márka - szöveg (max 50 karakter)
    -Hz - egész szám
    -Panel típusa - szöveg (Max 10 karakter)
    -Csatlakozó típusa - szöveg (Max 20 karakter)
    -Ár - egész szám
    Mindegyik mezőre állítsa be, hogy ne legyen NULL érték

3. Feladat: Szurjon be három adatot a táblába.
*/

/* 1. Feladat */
CREATE DATABASE perifériák
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

/* 2. Feladat */
CREATE TABLE monitor(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    márka VARCHAR(50) NOT NULL,
    Hz INT NOT NULL,
    Panel VARCHAR(10) NOT NULL,
    Csatlakozó_típusa VARCHAR(20) NOT NULL,
    Ár INT NOT NULL
);

/* 3. Feladat */
INSERT INTO monitor(márka, Hz, Panel, Csatlakozó_típusa, Ár) VALUES
('Acer', 144, 'OLED', 'HDMI', 128000),
('Asus', 120, 'AMOLED', 'HDMI', 99990),
('Dell', 60, 'IPS', 'AVG', 17990),
('LG', 60, 'OLED', 'HDMI', 59990);

/*4. Feladat: Készítsen lekérdezést, ami megjeleníti minden olyan monitor márkáját, árát és csatlakozó típusát, ami 144-Hz-es

5. Feladata: Készítsen lekérdezést, ami megadja , hogy hány darab LG monitor van.

6. Feladat: Készítsen lekérdezést, ami megadja, hogy mennyi a monitorok átlagára.

7. Feladat: Készítsen lekérdezést, ami megjeleníti az összes monitor adatát ár szerint csökkenő sorrendben.

8. Feladat: Dobd el a monitor táblát.

9. Feladat: Dobd el a perifériák adatbázist.
*/

/* 4. Feladat */
SELECT márka AS'Márka:', Csatlakozó_típusa AS'Csatlakozó típusa:', ár AS'Ár:'
FROM monitor
WHERE  Hz LIKE 144;

/* 5. Feladat */
SELECT COUNT(id) AS'LG monitorok száma:'
FROM monitor
WHERE márka LIKE'LG';

/* 6. Feladat */
SELECT AVG(ár) AS'Monitorok átlagára:'
FROM monitor;

/* 7. Feladat */
SELECT id, márka AS 'Márka',Hz,Panel AS'Panel típusa:',Csatlakozó_típusa AS'Csatlakozó típusa:',ár AS'Ár'
FROM monitor
ORDER BY ár DESC;

/* 8. Feladat */
DROP TABLE monitor

/* 9. Feladat */
DROP DATABASE perifériák