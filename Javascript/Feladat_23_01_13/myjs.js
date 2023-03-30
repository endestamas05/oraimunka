/*1. Feladat*/
let kitalalando;
let kor;

window.addEventListener("load", loaded);

function loaded() {
    kitalalando = Math.floor(Math.random() * 100);

    kor = 1;
    document.getElementById("korszam").innerHTML = "Kör: " + kor + "/10";
}

function guess() {
    if (kor <= 10)
    {
        let number = parseInt(document.getElementById("number").value);

        if (number < kitalalando) {
            alert("Nagyobb számra gondoltunk!");
        }
        else if (number > kitalalando) {
            alert("Kissebb számra gondoltunk!");
        }
        else {
            alert("Kitalálta a számot!");
        }

        kor++;
        document.getElementById("korszam").innerHTML = "Kör: " + kor + "/10";
    }
    else
    {
        alert("Nincs több lehetőség! Frissítse az oldalt!");
    }
}

/*2. Feladat*/
let array = [];

function add() {
    array.push(parseInt(document.getElementById("numberAdd").value));
    let content = "Számok: ";
    for (let item of array) {
        //Végigjárjuk az array tartalmát és az indexedik elemre az item segítségével hivatkozhatunk.
        content += item + " "; //content += array[i]
    }
    document.getElementById("numbers").innerHTML = content;
    document.getElementById("numberAdd").value = "";

    document.getElementById("elem1").innerHTML = "Összeg: " + sum(array);
    document.getElementById("elem2").innerHTML = "Páros darab: " + parosdb(array);
    document.getElementById("elem3").innerHTML = "Van-e páratlan: " + paratlanvane(array);
    document.getElementById("elem4").innerHTML = "Legkissebb érték: " + mine(array);
    document.getElementById("elem5").innerHTML = "Legnagyobb hely: " + maxh(array);
}

/*
    Feladat:

    <p id="elem1">Összeg: </p>
    <p id="elem2">Páros darab: </p>
    <p id="elem3">Van-e páratlan: </p>
    <p id="elem4">Legkisebb érték: </p>
    <p id="elem5">Legnagyobb hely: </p>

    Elemi tételek kiírása, function-ok segítségével.
*/


function sum(array = []) {
    let osszeg = 0;
    for (item of array)
    {
        osszeg += item;
    }
    return osszeg;
}

function parosdb(array = []) {
    let db = 0;
    for (item of array)
    {
        if(item%2 == 0)
        {
            db++;
        }
    }
    return db;
}

function paratlanvane(array = []) {
    let j = 0;
    while (j < array.length && array[j]%2 == 0)
    {
        j++;
    }

    if(j<array.length)
    {
        return "Van!"
    }
    else
    {
        return "Nincs!"
    }
}

function mine(array = []) {
    let min_e = array[0];
    for (item of array)
    {
        if(min_e>item)
        {
            min_e = item;
        }
    }
    return min_e;
}

function maxh(array = []) {
    let max_h = 0;
    for (let i = 0; i<array.length; i++)
    {
        if(array[max_h]<array[i])
        {
            max_h = i;
        }
    }
    return max_h;
}