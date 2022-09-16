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

console.log("A kör kerülete:",kor_kerulete)
console.log("A kör területe:",kor_terulete)

console.log("")

//4. Feladat