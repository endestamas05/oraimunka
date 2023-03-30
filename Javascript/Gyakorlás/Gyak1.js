//1. Feladat
let tomb1=[]
for (let i=0;i<10;i++)
{
    tomb1[i]=Math.floor(Math.random()*101)
}
console.log(tomb1)
for (let i=0;i<5;i++)
{
    console.log(tomb1[i])
}

//2. Feladat
let tomb2=[]
for (let i=0;i<10;i++)
{
    tomb2[i]=Math.floor(Math.random()*101)
}
console.log(tomb2)
for (let i=5;i<10;i++)
{
    console.log(tomb2[i])
}

//3. Feladat
let tomb3=[]
for (let i=0;i<10;i++)
{
    tomb3[i]=Math.floor(Math.random()*100)
}
console.log(tomb3)
let osszeg3=tomb3[0]+tomb3[tomb3.length-1]
console.log("Első és utolsó elem összege:",osszeg3)

//4. Feladat
let tomb4=[]
let db4=0
for (let i=0;i<10;i++)
{
    tomb4[i]=Math.floor(Math.random()*100)
}
console.log(tomb4)
for (let i=0;i<tomb4.length;i++)
{
    if(tomb4[i]<tomb4[i+1])
    {
        db4++
    }
}
console.log("Nagyobb számok:",db4)

//5. Feladat
let tomb5=[]
let db5=0
for (let i=0;i<10;i++)
{
    tomb5[i]=Math.floor(Math.random()*21)
}
console.log(tomb5)
for (let i=0;i<tomb5.length;i++)
{
    if(tomb5[i]==tomb5[i+1])
    {
        db5++
    }
}
console.log("Egyforma számok:",db5)

//6. Feladat
let tomb6=[]
let db6=0
for (let i=0;i<10;i++)
{
    tomb6[i]=Math.floor(Math.random()*21)
}
console.log(tomb6)
for (let i=0;i<tomb6.length;i++)
{
    if(tomb6[i]*2==tomb6[i+1])
    {
        db6++
    }
}
console.log("Kétszer nagyobb számok:",db6)

//7. Feladat
let tomb7=[]
for (let i=0;i<5;i++)
{
    tomb7[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét (csak páros számok): "))
    while(tomb7[i]%2!=0)
    {
        tomb7[i]=parseInt(prompt("Páros számot adjon meg: "))
    }
}
console.log(tomb7)

//8. Feladat
let tomb8=[]
for (let i=0;i<20;i++)
{
    tomb8[i]=i+1
}
console.log(tomb8)

//9. Feladat
let tomb9=[]
for (let i=0;i<3;i++)
{
    tomb9[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét (csak pozitv számok): "))
    while(tomb9[i]<0)
    {
        tomb9[i]=parseInt(prompt("Pozitív számot adjon meg: "))
    }
}
console.log(tomb9)

//10. Feladat
let tomb10=[]
for (let i=0;i<4;i++)
{
    tomb10[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét (10 és 30 közötti számok): "))
    while(tomb10[i]>30 || tomb10[i]<10)
    {
        tomb10[i]=parseInt(prompt("10 és 30 közötti számot adjon meg: "))
    }
}
console.log(tomb10)

//11. Feladat
let tomb11=[]
for (let i=0;i<10;i++)
{
    tomb11[i]=Math.floor(Math.random()*9)+1
}
console.log(tomb11)
let tomb11_2=[]
for (let i=0;i<tomb11.length;i++)
{
    if(tomb11[i]%2==0)
    {
        tomb11_2.push(tomb11[i])
    }
}
console.log("Páros számokn:",tomb11_2)

//18. Feladat
let tomb18=[]
for (let i=0;i<100;i++)
{
    tomb18[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét (0 beolvasás vége): "))
    if(tomb18[i]==0)
    {
        tomb18.pop()
        break
    }
}
console.log(tomb18)

let min_e=tomb18[0]
for (let i=1;i<tomb18.length;i++)
{
    if(min_e>tomb18[i])
    {
        min_e=tomb18[i]
    }
}
console.log("Legkissebb érték:",min_e)

let min_h=0
for (let i=0;i<tomb18.length;i++)
{
    if(tomb18[min_h]>tomb18[i])
    {
        min_h=i
    }
}
console.log("Min hely:",min_h)

let max_e=tomb18[0]
for (let i=1;i<tomb18.length;i++)
{
    if(max_e<tomb18[i])
    {
        max_e=tomb18[i]
    }
}
console.log("Legnagyobb érték:",max_e)

let max_h=0
for (let i=0;i<tomb18.length;i++)
{
    if(tomb18[max_h]<tomb18[i])
    {
        max_h=i
    }
}
console.log("Max hely:",max_h)

for (let i=tomb18.length-1;i>=0;i--)
{
    console.log(tomb18[i])
}

//22. Feladat
let tomb22=[]
for (let i=0;i<10;i++)
{
    tomb22[i]=Math.floor(Math.random()*41)
}
console.log(tomb22)

let elsopar=0
let utolsopar=tomb22.length-1

while(elsopar<tomb22.length && tomb22[elsopar]%2==0)
{
    elsopar++
}
while(utolsopar>=0 && tomb22[utolsopar]%2==0)
{
    utolsopar--
}

if(elsopar<tomb22.length)
{
    console.log("Első páratlan szám inexe:",elsopar)
    console.log("Utolsó páratlan szám indexe:",utolsopar)
}
else
{
    console.log("Nincs benne páratlan szám!")
}