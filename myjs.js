//1. Feladat
let tomb1=[]
for(let i=0; i < 10; i++)
{
    let random=Math.floor(Math.random()*100-1)+1
    tomb1[i]=random
}

console.log(tomb1)

for(let i=0;i<5;i++)
{
    console.log(tomb1[i])
}

//2. Feladat
let tomb2=[]
for (let i=0;i<10;i++)
{
    let random=Math.floor(Math.random()*100-1)+1
    tomb2[i]=random
}

console.log(tomb2)

for(let i=9;i>4;i--)
{
    console.log(tomb2[i])
}

//3. Feladat
let tomb3=[]
for (let i=0;i<10;i++)
{
    let random=Math.floor(Math.random()*100-1)+1
    tomb3[i]=random
}
let osszeg3=tomb3[0]+tomb3[9]
console.log(tomb3)
console.log(osszeg3)

//4. Feladat
let tomb4=[];
for (let i=0;i<10;i++)
{
    let random=Math.floor(Math.random()*100-1)+1
    tomb4[i]=random
}

console.log(tomb4)

var db4=0
for(let i=0;i<10;i++)
{
    if(tomb4[i]<tomb4[i+1])
    {
        db4=db4+1
    }
}
console.log(db4)

//5. Feladat
let tomb5=[];
for (let i=0;i<10;i++)
{
    let random=Math.floor(Math.random()*20-1)+1
    tomb5[i]=random
}

console.log(tomb5)

var db5=0
for(let i=0;i<10;i++)
{
    if(tomb5[i]==tomb5[i+1])
    {
        db5=db5+1
    }
}
console.log(db5)

//6. Feladat
let tomb6=[];
for (let i=0;i<10;i++)
{
    let random=Math.floor(Math.random()*20-1)+1
    tomb6[i]=random
}

console.log(tomb6)

var db6=0
for(let i=0;i<10;i++)
{
    if(tomb6[i]*2==tomb6[i+1])
    {
        db6=db6+1
    }
}
console.log(db6)

//7. Feladat
let tomb7=[]
for(let i=0;i<5;i++)
{
    tomb7[i]=parseInt(prompt("Adjon meg a tömb "+(i+1)+". elemét (páros szám): "))
    while(tomb7[i]%2!=0)
    {
        tomb7[i]=parseInt(prompt("Csak páros számot adhat meg: "))
    }
}

console.log(tomb7)

//8. Feladat
let tomb8=[];
for (let i=0;i<20;i++)
{
    tomb8[i]=i+1
}

console.log(tomb8)

//9. Feladat
let tomb9=[]
for (let i = 0; i<3; i++)
{
    tomb9[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét (csak pozitív számok): "))
    while (tomb9[i]<= 0)
    {
        tomb9[i]=parseInt(prompt("Csak pozitív számot adahat meg: "))
    }
}

console.log(tomb9)

//10. Feladat
let tomb10=[]
for (let i = 0; i<3; i++)
{
    tomb10[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét (10 és 30 között): "))
    while (tomb10[i]<10 || tomb10[i]>30)
    {
        tomb10[i]=parseInt(prompt("10 és 30 között adjon meg számot: "))
    }
}

console.log(tomb10)

//11. Feladat
console.log("Tömb 11:")
let tomb11=[]
for (let i = 0; i<10; i++)
{
    let random11= Math.floor(Math.random() * 11-1)+1;
    tomb11[i]=random11
    console.log(tomb11[i])
}

console.log("Tömb 11_2:")

let tomb11_2=[]
for (let i = 0; i<tomb11.length; i++)
{
    if(tomb11[i]%2==0)
    {
        tomb11_2.push(tomb11[i])
    }
}

console.log(tomb11_2)

//12. Feladat
let tomb12=[]
for (let i = 0; i<20; i++)
{
    tomb12[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét: "))
}

console.log(tomb12)

let valaszt12=parseInt(prompt("Adjon meg egy számot 1 és 4 között (1 páros számok, 2 páratlan számok, 3 pozitív számok, 4 negatív számok): "))

switch(valaszt12)
{
    case 1: console.log("Páros számok: ")
    for (let i = 0; tomb12.length; i++)
    {
        if(tomb12[i]%2 == 0)
        {
            console.log(tomb12[i])
        }
    }
    ; break;
    case 2: console.log("Páratlan számok: ")
    for (let i = 0; tomb12.length; i++)
    {
        if(tomb12[i]%2 != 0)
        {
            console.log(tomb12[i])
        }
    }
    ; break;
    case 3: console.log("Pozitív számok számok: ")
    for (let i = 0; tomb12.length; i++)
    {
        if(tomb12[i]>=0)
        {
            console.log(tomb12[i])
        }
    }
    ; break;
    case 4: console.log("Negatív számok: ")
    for (let i = 0; tomb12.length; i++)
    {
        if(tomb12[i]<0)
        {
            console.log(tomb12[i])
        }
    }
    ; break;
    default: console.log("Rossz számot adott meg!"); break;
}

//13. Feladat
let maxn
do
{
    maxn=parseInt(prompt("1 és 20 között adjon meg számot: "))
} while (maxn>20 || maxn<1)

let tomb13=[]
for (let i = 0; i<maxn; i++)
{
    tomb13[i]=prompt("Adja meg a tömb "+(i+1)+". karakterét: ")
}
console.log(tomb13)

//14. Feladat
let tomb14=[]
for (let i = 0; i<20; i++)
{
    let random14= Math.floor(Math.random() * 101-1)+1;
    tomb14[i]=random14    
}

for (let i = 0; i < tomb14.length; i++)
{
    if(i<tomb14.length-1)
    {
        console.log((tomb14[i])+";")
    }
    else
    {
        console.log((tomb14[i]))
    }
}

let osszeg14=0
for (let i = 0; i<tomb14.length; i++)
{
    osszeg14+=tomb14[i]
}

console.log("A számok összege:",osszeg14)

let db14=0
for (let i = 0; i<tomb14.length; i++)
{
    db14++
}

let atlag14=osszeg14/db14

console.log("A számok átlaga:",atlag14)

let paros_db14=0
let paratlan_db14=0
for (let i = 0; i<tomb14.length; i++)
{
    if(tomb14[i]%2==0)
    {
        paros_db14++
    }
    else
    {
        paratlan_db14++
    }
}

console.log("Páros számok:",paros_db14)
console.log("Páratlan számok:",paratlan_db14)

let oszthato14=0
for (let i = 0; i<tomb14.length; i++)
{
    if(tomb14[i]%23==0)
    {
        oszthato14++
    }
}

if(oszthato14>0)
{
    console.log("Van 23-al osztható szám!")
}
else
{
    console.log("Nincs 23-al osztható szám!")
}

j14=0
while(j14<tomb14.length && tomb14[j14]!=25)
{
    j14++
}

if(j14<tomb14.length)
{
    console.log("Van 25 a lsitában! Indexe:",j14)
}
else
{
    console.log("Nincs 25 a lsitában!")
}

let min_e=tomb14[0]
for(let i=1;i<tomb14.length;i++)
{
    if(min_e>tomb14[i])
    {
        min_e=tomb14[i]
    }
}
console.log("Legkisebb érték:",min_e)

let max_e=tomb14[0]
for(let i=1;i<tomb14.length;i++)
{
    if(max_e<tomb14[i])
    {
        max_e=tomb14[i]
    }
}
console.log("Legnagyobbb érték:",max_e)

let min_i=0
for(let i=0;i<tomb14.length;i++)
{
    if(tomb14[min_i]>tomb14[i])
    {
        min_i=i
    }
}
console.log("Legkisebb index:",min_i)

let max_i=0
for(let i=0;i<tomb14.length;i++)
{
    if(tomb14[max_i]<tomb14[i])
    {
        max_i=i
    }
}
console.log("Legkisebb index:",max_i)

let osszeg5_14=0
let db5_14=0
for(let i=0;i<tomb14.length;i++)
{
    if(tomb14[i]%5==0)
    {
        osszeg5_14+=tomb14[i]
        db5_14++
    }
}

let atlag5_14=osszeg5_14/db5_14
console.log("Az 5-el osztható számok átlaga:",atlag5_14)

//15. Feladat
let tomb15=[]
for(let i=0;i<10;i++)
{
    tomb15[i]=prompt("Adja meg a tömb "+(i+1)+". karakterét: ")
}

for (let i = 0; i < tomb15.length; i++)
{
    if(i<tomb15.length-1)
    {
        console.log((tomb15[i])+",")
    }
    else
    {
        console.log((tomb15[i]))
    }
}

let a15=0

while(a15<tomb15.length && tomb15[a15]!='a')
{
    a15++
}

if(a15<tomb15.length)
{
    console.log("Van a karakter a tömbben!")
}
else
{
    console.log("Nincs a karakter a tömbben!")
}


let c15=0

while(c15<tomb15.length && tomb15[c15]!='c')
{
    c15++
}

if(c15<tomb15.length)
{
    console.log("Van c karakter a tömbben! Indexe:",c15)
}
else
{
    console.log("Nincs c karakter a tömbben!")
}

let cdb15=0
for(let i=0;i<tomb15.length;i++)
{
    if(tomb15[i]=='c')
    {
        cdb15++
    }
}

console.log("C betűk a listában:",cdb15)

//16. Feladat
let tomb16=[]
for (let i=0;i<20;i++)
{
    let random=Math.floor(Math.random()*50-1)+2
    tomb16[i]=random
}
console.log(tomb16)

let paros_osszeg16=0
let paros_db16=0
for(let i=0;i<tomb16.length;i++)
{
    if(tomb16[i]%2==0)
    {
    paros_osszeg16+=tomb16[i]
    paros_db16++
    }
}
console.log("Páros számok összege:",paros_osszeg16)
console.log("Páros számok:",paros_db16)
let paros_atlag16=paros_osszeg16/paros_db16
console.log("Páros számok átlaga:",paros_atlag16)

if (paros_db16<tomb16.length)
{
    console.log("Van benne páratlan szám.")
}
else
{
    console.log("Nincs benne páratlan szám.")
}

//17. Feladat
let maxn17
do
{
    maxn17=parseInt(prompt("Tömb hossza (1 és 20 között): "))
}
while(maxn17<1 && maxn17>20)

let tomb17=[]
for(let i=0;i<maxn17;i++)
{
    let rnd=Math.floor(Math.random()*20)+1
    tomb17[i]=rnd
}

console.log(tomb17)

let osszeg17=0
for(let i=0;i<tomb17.length;i++)
{
    osszeg17+=tomb17[i]
}
console.log("Tömb elemeinek összege:",osszeg17)

let oszhtato10_17=0
for(let i=0;i<tomb17.length;i++)
{
    if(tomb17[i]%10==0)
    {
        oszhtato10_17++
    }
}
console.log("Tízzel osztható számok:",oszhtato10_17)

let j17=0

while(j17<tomb17.length && tomb17[j17]!=5)
{
    j17++
}

if(j17<tomb17.length)
{
    console.log("Van benne 5-ös!")
}
else
{
    console.log("Nincs benne 5-ös!")
}

let j17_2=0

while(j17_2<tomb17.length && tomb17[j17_2]%5 != 0)
{
    j17_2++
}

if(j17_2<tomb17.length)
{
    console.log("Van benne 5-el osztható szám! Indexe:",j17_2)
}
else
{
    console.log("Nincs benne 5-el osztható szám!")
}

let max_e17=tomb17[0]
for(let i=1;i<tomb17.length;i++)
{
    if(max_e17<tomb17[i])
    {
        max_e17=tomb17[i]
    }
}

console.log("Maximum érték:",max_e17)

let min_h17=0
for(let i=1;i<tomb17.length;i++)
{
    if(tomb17[min_h17]>tomb17[i])
    {
        min_h17=i
    }
}

console.log("Minimum hely:",min_h17)

let oszthato3_17=0
let oszthato3_db_17=0
for(let i=1;i<tomb17.length;i++)
{
    if(tomb17[i]%3==0)
    {
        oszthato3_17+=tomb17[i]
        oszthato3_db_17++
    }
}
let atlag17=oszthato3_17/oszthato3_db_17
console.log("3-al osztható számok átlaga:",atlag17)

//18. Feladat
let tomb18=[]
for (let i=0;i<100;i++)
{
    tomb18[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét vagy 0-át a befejezéshez: "))
    if(tomb18[i]==0)
    {
        tomb18.pop()
        break
    }
}

console.log(tomb18)

let max_e18=tomb18[0]
for(let i=1;i<tomb18.length;i++)
{
    if(max_e18<tomb18[i])
    {
        max_e18=tomb18[i]
    }
}
console.log("Legnagyobb érték:",max_e18)

let max_h18=0
for(let i=1;i<tomb18.length;i++)
{
    if(tomb18[0]<tomb18[i])
    {
        max_h18=i
    }
}
console.log("Max hely:",max_h18)

let min_e18=tomb18[0]
for(let i=1;i<tomb18.length;i++)
{
    if(min_e18>tomb18[i])
    {
        min_e18=tomb18[i]
    }
}
console.log("Legkisebb érték:",min_e18)

let min_h18=0
for(let i=1;i<tomb18.length;i++)
{
    if(tomb18[0]>tomb18[i])
    {
        min_h18=i
    }
}
console.log("Min hely:",min_h18)

for (let i=tomb18.length-1;i>=0;i--)
{
    console.log(tomb18[i])
}

//19. Feladat
let tomb19=[]
for (let i=0;i<20;i++)
{
    tomb19[i]=parseInt(prompt("Adja meg a tömb "+(i+1)+". elemét: "))
}

console.log(tomb19)

let keres19=parseInt(prompt("Keresett szám: "))

let j19=0
while(j19<tomb19.length && tomb19[j19]!= keres19)
{
    j19++
}

if(j19<tomb19.length)
{
    console.log("Benne van a szám! Indexe:",j19)
}
else
{
    console.log("Nincs benne a szám!")
}

//20. Feladat
let tomb20=[]
for(let i=0;i<50;i++)
{
    let rnd=Math.floor(Math.random()*9)+1
    tomb20[i]=rnd
}

console.log(tomb20)

let osszeg20=0
for(let i=0;i<tomb20.length;i++)
{
    osszeg20+=tomb20[i]
}

console.log("Elemek összege:",osszeg20)

let keres20=parseInt(prompt("Keresett szám 1 és 9 között: "))
let keresdb20=0
for(let i=0;i<tomb20.length;i++)
{
    if(tomb20[i]==keres20)
    {
        keresdb20++
    }
}
console.log(keresdb20+" db szám található "+keres20+"-as ból/-es ből")

//21. Feladat
let tomb21=[]
for(let i=0;i<20;i++)
{
    tomb21[i]=Math.floor(Math.random()*46)-20;
}
console.log("Szóközökkel elválasztva:")
for(let i=0;i<tomb21.length;i++)
{
    console.log(tomb21[i]+" ")
}

console.log("Egymás alatt:")
for(let i=0;i<tomb21.length;i++)
{
    console.log(tomb21[i])
}

console.log("Negatív számok: ")
for(let i=0;i<tomb21.length;i++)
{
    if(tomb21[i]<0)
    {
        console.log(tomb21[i])
    }
}

console.log("Pozitív számok: ")
for(let i=0;i<tomb21.length;i++)
{
    if(tomb21[i]>=0)
    {
        console.log(tomb21[i])
    }
}

console.log("Első elem:",tomb21[0])
console.log("Utolsó elem:",tomb21[tomb21.length-1])

console.log("Minden második elem:")
for(let i=1;i<tomb21.length;i+=2)
{
    console.log(tomb21[i])
}

console.log("Nagyobb elemek: ")
for(let i=0;i<tomb21.length;i++)
{
    if(tomb21[i]<tomb21[i+1])
    {
        console.log(tomb21[i])
    }
}

console.log("[-5;5] intervallum: ")
for(let i=0;i<tomb21.length;i++)
{
    if(tomb21[i]>=-5 && tomb21[i]<=5)
    {
        console.log(tomb21[i])
    }
}

console.log("[-10;-5] nincs benne az intervallum: ")
for(let i=0;i<tomb21.length;i++)
{
    if(tomb21[i]<-10 || tomb21[i]>=-5)
    {
        console.log(tomb21[i])
    }
}

console.log("Tömb elemei visszafele: ")
for(let i=tomb21.length-1;i>=0;i--)
{
    console.log(tomb21[i])
}

let j21=0
while(j21<tomb21.length && tomb21[j21]!=tomb21[j21+1])
{
    j21++
}

if(j21<tomb21.length)
{
    console.log("Van egymás mellett két egyforma szám!")
}
else
{
    console.log("Nincs egymás mellett két egyforma szám!")
}

//22. fELADAT
let tomb22=[]
for(let i=0;i<10;i++)
{
    tomb22[i]=Math.floor(Math.random()*40+1)
}

console.log(tomb22)

let elspar = 0;
let utspar = tomb22.length - 1
while (elspar < tomb22.length && tomb22[elspar] % 2 == 0)
{
    elspar++
}
while (utspar >= 0 && tomb22[utspar] % 2 == 0)
{
    utspar--
}
if (elspar < tomb22.length && utspar >= 0)
{
    console.log("Első páratlan indexe: "+(elspar)+" utolsóé: "+(utspar))
}
else
{
    console.log("Nincs páratlan szám!")
}




let tomb22_2=[]
for (let i=0;i<10;i++)
{
    tomb22_2[i]=Math.floor(Math.random()*41)
}
console.log(tomb22_2)

let elsopar_2=0
let utolsopar_2=tomb22_2.length-1

while(elsopar_2<tomb22_2.length && tomb22_2[elsopar_2]%2==0)
{
    elsopar_2++
}
while(utolsopar_2>=0 && tomb22_2[utolsopar_2]%2==0)
{
    utolsopar_2--
}

if(elsopar_2<tomb22_2.length)
{
    console.log("Első páratlan szám inexe:",elsopar_2)
    console.log("Utolsó páratlan szám indexe:",utolsopar_2)
}
else
{
    console.log("Nincs benne páratlan szám!")
}
