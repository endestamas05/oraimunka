window.addEventListener("load", loaded);


function check() {
    let user = document.getElementById("user").value;
    if (user.length === 0) {
        alert("Nem adott meg felhasználónevet!");
        return;
    }
    let jelszo = document.getElementById("pass").value;
    if (jelszo.length === 0) {
        alert("Nem adott meg jelszót!");
        return;
    }
    let nemek = document.getElementsByName("nem");
    let nem = "";
    for (let item of nemek) {
        if (item.checked) {
            nem = item.value;
        }
    }
    if (nem.length === 0) {
        alert("Nem választott nemet!");
        return;
    }
    let tantargy = document.getElementsByName("tantargy");
    let best = [];
    for (let item of tantargy) {
        if (item.checked) {
            best.push(item.value);
        }
    }
    if (best.length === 0) {
        alert("Nem választott tantárgyat!");
        return;
    }

    let msg = "Felhasználónév: " + user + " | Jelszó: " + jelszo + " | Nem: " + nem + "| Kedvenc tantárgy: ";
    for (let item of best) {
        msg += item + " ";
    }
    document.getElementById("szoveg").innerHTML = msg;
}