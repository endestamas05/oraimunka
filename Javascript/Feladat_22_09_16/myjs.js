console.log("TESZT");

console.log("");

//1. Feladat
var negyzet_a=parseInt(prompt("Adja meg a négzet oldalát: "));
console.log("Adja meg a négzet oldalát:",negyzet_a)
var negyzet_kerület=negyzet_a*4;
var negyzet_terulet=Math.pow(negyzet_a,2);

console.log("\tNégyzet kerülete:",negyzet_kerület);
console.log("\tNégyzet területe:",negyzet_terulet);

console.log("");

//2. Feladat
var teglalap_a=parseInt(prompt("Adja meg a téglalap a oldalát: "));
var teglalap_b=parseInt(prompt("Adja meg a téglalap b oldalát: "));
console.log("Adja meg a téglalap a oldalát:",teglalap_a);
console.log("Adja meg a téglalap b oldalát:",teglalap_b);
var teglalap_kerulete=2*(teglalap_a+teglalap_b);
var teglalap_terulete=teglalap_a*teglalap_b;

console.log("\tTéglalap kerülete:",teglalap_kerulete);
console.log("\tTéglalap területe:",teglalap_terulete);

console.log("");

//3. Feladat
var r=parseInt(prompt("Adja meg a kör sugarát: "));
var kor_kerulete=2*r*Math.PI;
var kor_terulete=Math.pow(r,2)*Math.PI;

console.log("A kör kerülete:",kor_kerulete);
console.log("A kör területe:",kor_terulete);

console.log("");

//4. Feladat
var gomb_r=parseInt(prompt("Adja meg a gömb sugarát: "));
var gomb_felszine=4*Math.pow(gomb_r,2)*Math.PI;
var gomb_terfogata=(4*Math.pow(gomb_r,3)*Math.PI)/3;

console.log("A gömb felszíne:",gomb_felszine);
console.log("A gömb térfogata:",gomb_terfogata);

console.log("");

//5. Feladat
var szam=parseInt(prompt("Adjon meg egy számot: "))
if(szam>=0)
{
    console.log("A szám pozitív!");
}
else
{
    console.log("A szám negatív!");
}

if(szam%2==0)
{
    console.log("A szám páros!");
}
else
{
    console.log("A szám páratlan!");
}

if(szam>5 && szam<=101)
{
    console.log("A szám benne van az intervallumban!");
}
else
{
    console.log("A szám nincs benne az intervallumban!");
}

console.log("");

//6. Feladat
var kor=parseInt(prompt("Adja meg az életkorát: "))
if(kor>=0 && kor<1)
{
    console.log("Csecsemőkor");
}
else if(kor>=1 && kor<3)
{
    console.log("Kisgyermekkor");
}
else if(kor>=3 && kor<6)
{
    console.log("Óvodáskor");
}
else if(kor>=6 && kor<12)
{
    console.log("Kisiskoláskor");
}
else if(kor>=12 && kor<17)
{
    console.log("Serdülőkor");
}
else if(kor>=17 && kor<24)
{
    console.log("Ifjúkor");
}
else if(kor>=24 && kor<35)
{
    console.log("Fiatal felnőttkor");
}
else if(kor>=35 && kor<60)
{
    console.log("Felnőttkor");
}
else if(kor>=60 && kor<80)
{
    console.log("Időskor");
}
else if(kor>=80)
{
    console.log("Aggkor");
}
else
{
    console.log("Érvénytelen életkort adott meg!");
}

console.log("");
//7. Feladat
var szam1=parseInt(prompt("Adja meg az 1. számot: "))
var szam2=parseInt(prompt("Adja meg a 2. számot: "))
var szam3=parseInt(prompt("Adja meg a 3. számot: "))

console.log("Növekvő sorrend: ");
if (szam1 >= szam2 && szam1 >= szam3 && szam2 >= szam3)
{
    console.log("\t",szam3,szam2,szam1);
}
else if (szam1 >= szam2 && szam1 >= szam3 && szam2 <= szam3)
{
    console.log("\t",szam2,szam3,szam1);
}
else if (szam1 <= szam2 && szam1 >= szam3 && szam2 >= szam3)
{
    console.log("\t",szam3,szam1,szam2);
}
else if (szam1 <= szam2 && szam1 <= szam3 && szam2 >= szam3)
{
    console.log("\t",szam1,szam3,szam2);
}
else if (szam1 >= szam2 && szam1 <= szam3 && szam2 <= szam3)
{
    console.log("\t",szam2,szam1,szam3);
}
else if (szam1 <= szam2 && szam1 <= szam3 && szam2 <= szam3)
{
    console.log("\t",szam1,szam2,szam3);
}

//8. Feladat
console.log("Csökkenő sorrend:");

if (szam1 >= szam2 && szam1 >= szam3 && szam2 >= szam3)
{
    console.log("\t",szam1,szam2,szam3);
}
else if(szam1 >= szam2 && szam1 >= szam3 && szam2 <= szam3)
{
    console.log("\t",szam1,szam3,szam2);
}
else if (szam1 <= szam2 && szam1 >= szam3 && szam2 >= szam3)
{
    console.log("\t",szam2,szam1,szam3);
}
else if (szam1 <= szam2 && szam1 <= szam3 && szam2 >= szam3)
{
    console.log("\t",szam2,szam3,szam1);
}
else if (szam1 >= szam2 && szam1 <= szam3 && szam2 <= szam3)
{
    console.log("\t",szam3,szam1,szam2);
}
else if (szam1 <= szam2 && szam1 <= szam3 && szam2 <= szam3)
{
    console.log("\t",szam3,szam2,szam1);
}

console.log("");

//9. Feladat
var burgonya_kg=parseInt(prompt("Vásárolt burgonya mennyisége (kg): "));
var repa_kg=parseInt(prompt("Vásárolt répa mennyisége (kg): "));
var kaposzta_kg=parseInt(prompt("Vásárolt káposzta mennyisége (kg): "));
var burgonya_ar=burgonya_kg*300;
var repa_ar=repa_kg*400;
var kaposzta_ar=kaposzta_kg*600;
var ossz_ar=burgonya_ar+repa_ar+kaposzta_ar;

console.log("A borgonya",burgonya_ar,"Ft lessz.");
console.log("A répa",repa_ar,"Ft lessz.");
console.log("A káposzta",kaposzta_ar,"Ft lessz.");
console.log("Összesen:",ossz_ar,"Ft");