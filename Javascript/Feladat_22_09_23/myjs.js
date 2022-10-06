//1. Feladat
var honap=parseInt(prompt("Adjon meg egy számot 1 és 12 között: "))

switch(honap)
{
    case 1: console.log("Január");break;
    case 2: console.log("Február");break;
    case 3: console.log("Március");break;
    case 4: console.log("Április");break;
    case 5: console.log("Május");break;
    case 6: console.log("Június");break;
    case 7: console.log("Július");break;
    case 8: console.log("Augusztus");break;
    case 9: console.log("Szeptember");break;
    case 10: console.log("Október");break;
    case 11: console.log("November");break;
    case 12: console.log("December");break;
    default: console.log("Rossz számot adott meg");break;
}

console.log("");

//2. Feladat
var szam1=parseInt(prompt("Adja meg az 1. számot: "))
var szam2=parseInt(prompt("Adja meg a 2. számot: "))
var osszeg=szam1+szam2;
var kulonbseg=Math.abs(szam1-szam2);
var szorzat=szam1*szam2;

console.log("Összegük:",osszeg);
console.log("Különbségük:",kulonbseg);
console.log("Szorzatuk:",szorzat);

console.log("");

//3. Feladat
var sz1=parseInt(prompt("Adja meg az első számot: "));
var sz2=parseInt(prompt("Adja meg a 2. számot: "));
var sz3=parseInt(prompt("Adja meg a 3. számot: "));
console.log("A legkissrbb szám: ")
if (sz1 <= sz2 && sz1 <= sz3)
{
    console.log("\t",sz1);
}
else if (sz2 <= sz1 && sz2 <= sz3)
{
    console.log("\t",sz2);
}
else
{
    console.log("\t",sz3);
}

//4. Feladat
console.log("A legnagyobb szám: ")
if (sz1 >= sz2 && sz1 >= sz3)
{
    console.log("\t",sz1);
}
else if (sz2 >= sz1 && sz2 >= sz3)
{
    console.log("\t",sz2);
}
else
{
    console.log("\t",sz3);
}

console.log("");

//5. Feladat
var kivetel_penz=parseInt(prompt("Adja meg a kivenni kívánt összeget (max 300 000 Ft): "))
var tizezresek=Math.floor(kivetel_penz/10000);
kivetel_penz=kivetel_penz-tizezresek*10000;
var otezresek=Math.floor(kivetel_penz/5000);
kivetel_penz=kivetel_penz-otezresek*5000;
var ezresek=Math.floor(kivetel_penz/1000);
kivetel_penz=kivetel_penz-ezresek*1000;
if(kivetel_penz%1000!=0)
{
    console.log("Ilyen összegben nem tud pénzt kivenni!")
}
else if(kivetel_penz>300000 && kivetel_penz<=0)
{
    console.log("Ilyen összegben nem tud pénzt kivenni!")
}
else
{
    console.log("Tízezresek:",tizezresek,"db");
    console.log("Ötezresek:",otezresek,"db");
    console.log("Ezresek:",ezresek,"db");
}

console.log("");

//6. Feladat
var nevezo1=parseInt(prompt("Adja meg az 1. nevezőt: "));
var nevezo2=parseInt(prompt("Adja meg a 2. nevezőt: "));
var szamlalo1=parseInt(prompt("Adja meg az 1. számlálót: "));
var szamlalo2=parseInt(prompt("Adja meg a 2. számlálót: "));
var kozos_nevezo=nevezo1*nevezo2;
if (nevezo1 == nevezo2)
{
    eredmeny = "",szamlalo1 + szamlalo2,"/",nevezo1,"";
}
else
{
    eredmeny = szamlalo1 * nevezo2,"+",szamlalo2 * nevezo1,"/",{kozos_nevezo};
}
console.log("\tAz eredmény:",eredmeny);

console.log("");

//7. Feladat
var szam3=parseInt(prompt("Ada meg az 1. egész számot: "));
var szam4=parseInt(prompt("Ada meg a 2. egész számot: "));

if(szam3%szam4==0 && szam4%szam3!=0)
{
    console.log("A második szám osztója az elsőnek");
}
else if(szam4%szam3==0 && szam3%szam4!=0)
{
    console.log("Az első szám osztója a másodiknak!");
}
else if(szam3%szam4==0 && szam4%szam3==0)
{
    console.log("A számok osztóik egymásnak!");
}
else
{
    console.log("A számok nem osztóik egymásnak!");
}

console.log("");

//8. Feladat
var a=parseInt(prompt("Adja meg a háromszög a oldalát: "));
var b=parseInt(prompt("Adja meg a háromszög b oldalát: "));
var c=parseInt(prompt("Adja meg a háromszög c oldalát: "));

if(a+b>c && a+c>b && b+c>a)
{
    console.log("\tA háromszög szerkeszthető!");
}
else
{
    console.log("\tA háromszög nem szerkeszthető!");
}

console.log("");

//9. Feladat
var keres=parseInt(prompt("Adjon meg egy számot [11;37]: "));
do
{
    if (keres >= 11 && keres <= 37)
    {
        console.log("\tMegtaláltad az intervallumot!");
    }
    else
    {
        var keres=parseInt(prompt("Adjon meg egy számot [11;37]: "));
        if (keres >= 11 && keres <= 37)
        {
            console.log("\tMegtaláltad az intervallumot!");
        }
    }
} while ((keres < 11) || (keres > 37));

console.log("");

//10. Feladat
var keres2=parseInt(prompt("Adjon meg egy számot, ami osztható 23-al: "));
do
{
    if(keres2%23==0)
    {
        console.log("A szám osztható 23-al!");
    }
    else
    {
        var keres2=parseInt(prompt("Adjon meg egy számot, ami osztható 23-al: "));
        if(keres2%23==0)
        {
            console.log("A szám osztható 23-al!");
        }
    }
} while (keres2%23!=0)

console.log("");

//11. Feladat
var nagybetu=prompt("Adjon meg egy nagybetűt: ");
console.log("Kisbetű:",nagybetu.toLowerCase());

console.log("");

//12. Feladat
var kisbetu=prompt("Adjon meg egy kisbetűt: ");
console.log("Nagybetű:",kisbetu.toUpperCase());

console.log("");

//13. Feladat
var Random=Math.random();
rnd=Math.floor(Random*101);
var Boolean=false;
var tippek_szama=0;

while (Boolean == false && tippek_szama < 5)
{
    var tipp= parseInt(prompt("Tippelt szám 1-100: "));
    if (tipp < rnd && tippek_szama <= 100 && tippek_szama >= 0)
    {
        tippek_szama++;
        console.log("\tNagyobb számra gondoltam!");
    }
    else if(tipp > rnd && tippek_szama <= 100 && tippek_szama >= 0)
    {
        tippek_szama++;
        console.log("\tKissebb számra gondoltam!");
    }
    else if (tipp == rnd)
    {
        tippek_szama++;
        console.log("\tKitaláltad a számot",tippek_szama,"tippből!");
        Boolean = true;
    }
    else
    {
        tippek_szama++;
        console.log("\tA szám 1 és 100 között van!");
    }
}

if (Boolean == false)
{
    console.log("Túl sokszor próbálkoztál!");
}