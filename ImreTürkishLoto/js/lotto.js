//Játékos számainak megadása
var elsoszelv = [];
var masodikszelv = [];
var harmadikszelv = [];
var evek = 0;

//Dátum megadása
var tdate = new Date();
var dd = ("0" + tdate.getDate()).slice(-2);
var MM = ("0" + (tdate.getMonth() + 1)).slice(-2);
var yyyy = tdate.getFullYear();
var xxx = yyyy + "." + MM + "." + dd + ".";
var xxxveg = yyyy + "." + 12 + "." + 31 + ".";
document.getElementById("date").innerHTML = xxx;
document.getElementById("dateveg").innerHTML = xxxveg;


//52 hét számai random
var nyeroszamok = [];
for (let i = 0; i < 52; i++) {
    nyeroszamok[i] = [];
    for (let j = 0; j < 5; j++) {
        let random;
        do {
            random = Math.floor(Math.random() * 89) + 1;
        } while (nyeroszamok[i].includes(random))
        nyeroszamok[i][j] = random;
    }
}

nyeroszamok.forEach(het => het.sort((a, b) => a - b));
for (let x = 0; x < 52; x++) {
    console.log(nyeroszamok[x])
}

//Tömbök feltöltése
function bevitel(szam) {
    if (!elsoszelv.includes(szam) && elsoszelv.length < 5) {
        elsoszelv.push(szam);
    } else if (elsoszelv.length == 5 && !masodikszelv.includes(szam) && masodikszelv.length < 5) {
        masodikszelv.push(szam);
    } else if ((elsoszelv.length == 5 && masodikszelv.length == 5) && !harmadikszelv.includes(szam) && harmadikszelv.length < 5) {
        harmadikszelv.push(szam);
    } else {
        alert("Ezt a számot már magadta vagy nem adhat meg több számot ezen a szelvényen!");
    }

    //rendezes
    for (let i = 0; i < elsoszelv.length - 1; i++) {
        for (let j = i + 1; j < elsoszelv.length; j++) {
            if (elsoszelv[i] > elsoszelv[j]) {
                let seged = elsoszelv[i];
                elsoszelv[i] = elsoszelv[j];
                elsoszelv[j] = seged;
            }
        }
    }

    for (let i = 0; i < masodikszelv.length - 1; i++) {
        for (let j = i + 1; j < masodikszelv.length; j++) {
            if (masodikszelv[i] > masodikszelv[j]) {
                let seged = masodikszelv[i];
                masodikszelv[i] = masodikszelv[j];
                masodikszelv[j] = seged;
            }
        }
    }

    for (let i = 0; i < harmadikszelv.length - 1; i++) {
        for (let j = i + 1; j < harmadikszelv.length; j++) {
            if (harmadikszelv[i] > harmadikszelv[j]) {
                let seged = harmadikszelv[i];
                harmadikszelv[i] = harmadikszelv[j];
                harmadikszelv[j] = seged;
            }
        }
    }

    var tomb1 = elsoszelv.join(' ');
    var tomb2 = masodikszelv.join(' ');
    var tomb3 = harmadikszelv.join(' ');

    //törlés
    document.getElementById("szamok1").innerHTML =
        `<button class="torles1">
        <span id="szams1">
            ${tomb1}
        </span>
        🗑️
    </button>
    `;
    document.getElementById("szamok2").innerHTML =
        `<button class="torles2">
        <span id="szams2">
            ${tomb2}
        </span>
        🗑️
    </button>
    `;
    document.getElementById("szamok3").innerHTML =
        `<button class="torles3">
        <span id="szams3">
            ${tomb3}
        </span>
        🗑️
    </button>
    `;

    let gombok1 = document.getElementsByClassName("torles1");
    for (let gomb1 of gombok1) {
        if ((masodikszelv.length == 0 || masodikszelv.length == 5) && (harmadikszelv.length == 0 || harmadikszelv.length == 5)) {
            gomb1.addEventListener("click", () => {
                gomb1.remove();
                elsoszelv = [];
            });
        }
    }

    let gombok2 = document.getElementsByClassName("torles2");
    for (let gomb2 of gombok2) {
        if ((harmadikszelv.length == 0 || harmadikszelv.length == 5) && (elsoszelv.length == 0 || elsoszelv.length == 5)) {
            gomb2.addEventListener("click", () => {
                gomb2.remove();
                masodikszelv = [];
            });
        }
    }
    let gombok3 = document.getElementsByClassName("torles3");
    for (let gomb3 of gombok3) {
        if ((masodikszelv.length == 0 || masodikszelv.length == 5) && (elsoszelv.length == 0 || elsoszelv.length == 5)) {
            gomb3.addEventListener("click", () => {
                gomb3.remove();
                harmadikszelv = [];
            });
        }
    }
}

function jatek() {
    evek++;
    if (elsoszelv.length == 5 && masodikszelv.length == 5 && harmadikszelv.length == 5) {

        let talalatok = [0, 0, 0, 0];
        let nyeremeny = 0;
        let money = 0;
        let mnyer = 0;
        const ar = 62400;
        for (let i = 0; i < nyeroszamok.length; i++) {
            let talalat1 = 0;
            let talalat2 = 0;
            let talalat3 = 0;

            for (let j = 0; j < nyeroszamok[i].length; j++) {
                if (elsoszelv.includes(nyeroszamok[i][j])) {
                    talalat1++;
                }
                if (masodikszelv.includes(nyeroszamok[i][j])) {
                    talalat2++;
                }
                if (harmadikszelv.includes(nyeroszamok[i][j])) {
                    talalat3++;
                }
            }

            if (talalat1 == 2 || talalat2 == 2 || talalat3 == 2) {
                talalatok[0]++;
            } else if (talalat1 == 3 || talalat2 == 3 || talalat3 == 3) {
                talalatok[1]++;
            } else if (talalat1 == 4 || talalat2 == 4 || talalat3 == 4) {
                talalatok[2]++;
            } else if (talalat1 == 5 || talalat2 == 5 || talalat3 == 5) {
                talalatok[3]++;
            }
        }

        nyeremeny += talalatok[0] * 3545 + talalatok[1] * 30140 + talalatok[2] * 1901800 + talalatok[3] * 5350000000;
        money = nyeremeny - ar;

        if (nyeremeny < ar) {
            let plusz = document.getElementById("penz").innerHTML = `<p class="eredmeny penz">Ez az év veszteséges volt, vesztett: ${money} Ft-ot</p>`
        } else if (nyeremeny == ar) {
            let nulla = document.getElementById("penz").innerHTML = `<p class="eredmeny penz">Ez az év nullás volt.</p>`
        } else {
            let minusz = document.getElementById("penz").innerHTML = `<p class="eredmeny penz">Ez az év nyereséges volt, nyert: ${money} Ft-ot</p>`
        }

        document.getElementById('eredmeny').innerHTML = ` 
        <div id="adatok">
            <p class="eredmeny">Kettes találatok: ${talalatok[0]}</p>
            <p class="eredmeny">Hármas találatok: ${talalatok[1]}</p>
            <p class="eredmeny">Négyes találatok: ${talalatok[2]}</p>
            <p class="eredmeny">Ötös találatok: ${talalatok[3]}</p>
            <p class="eredmeny">Eltelt évek: ${evek}</p>
        </div>
            `;

        for (let i = 0; i < 52; i++) {
            nyeroszamok[i] = [];
            for (let j = 0; j < 5; j++) {
                let random;
                do {
                    random = Math.floor(Math.random() * 89) + 1;
                } while (nyeroszamok[i].includes(random))
                nyeroszamok[i][j] = random;
            }
        }
        nyeroszamok.forEach(het => het.sort((a, b) => a - b));

        console.log("Nyeroszamopk")
        for (let l = 0; l < 52; l++) {
            console.log(nyeroszamok[l]);
        }
    } else {
        alert("Mielőtt megjátszaná a számokat töltse ki teljesen a nyelvényeket!")
    }
}