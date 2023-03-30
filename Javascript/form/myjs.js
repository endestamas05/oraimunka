/*1. Feladat:*/
let kitalalando;
let kor;
window.addEventListener("load", loaded);
function loaded() {
    kitalalando = Math.floor(Math.random() * 100);

    kor = 1;
    //document.getElementById("korszam").innerHTML = "Kör: " + kor + "/10";
}

function guess() {
    if(kor <= 10) {
        let number = parseInt(document.getElementById("number").value);

        if(number < kitalalando) {
            alert("Nagyobb számra gondoltunk.");
        } else if(number > kitalalando) {
            alert("Kisebb számra gondoltunk.");
        } else {
            alert("Eltalálta a számot!");
        }

        kor++;
        document.getElementById("korszam").innerHTML = "Kör: " + kor + "/10";
    } else {
        alert("Nincs több lehetőség! Frissítse az oldalt!");
    }
}

/*2. Feladat*/
let array = [];

function add() {
    array.push(parseInt(document.getElementById("numberAdd").value));
    let content = "Számok: ";
    for(let item of array) { //Végigjárjuk az array tartalmát és az indexedik elemre az item segíteségével hivatkozhatunk.
        content += item + " "; //content += array[i]
    }
    document.getElementById("numbers").innerHTML = content;
    document.getElementById("numberAdd").value = "";

    //Feladat:
    /*
    <p id="elem1">Összeg: </p>
    <p id="elem2">Páros darab: </p>
    <p id="elem3">Van-e páratlan: </p>
    <p id="elem4">Legkisebb érték: </p>
    <p id="elem5">Legnagyobb hely: </p>
    */
   //Elemi tételek kiírása, function-ök segítségével.
   document.getElementById("elem1").innerHTML = "Összeg: " + osszeg();
}

function osszeg() {
    let ossz = 0;
    for(let item of array) {
        ossz += item;
    }
    return ossz;
}

/*3. Feladat:*/
function check() {
    let uName = document.getElementById("uname").value;
    if(uName.length === 0) {
        alert("Nem írt be felhasználónevet!");
        return;
    }

    let uPass = document.getElementById("pass").value;
    if(uPass.length === 0) {
        alert("Nem írt be jelszót!");
        return;
    }

    let genders = document.getElementsByName("radioGender");
    let gender = "";
    for(let item of genders) {
        if(item.checked) { 
            gender = item.value;
        }
    }

    if(gender.length === 0) {
        alert("Nem választott nemet!");
        return;
    }

    let subjects = document.getElementsByName("checkSubject");
    let best = [];
    for(let item of subjects) {
        if(item.checked) {
            best.push(item.value);
        }
    }

    if(best.length === 0) {
        alert("Nem választott kedvenc tantárgyat/tantárgyakat!");
        return;
    }

    let msg = "Felhasználónév: " + uName + " | Jelszó: " + uPass + " | Nem: " + gender + " | Kedvenc tantárgy/tantárgyak: ";
    for(let item of best) {
        msg += item + " ";
    }
    document.getElementById("info").innerHTML = msg;
}