//1. Feladat
var szam1_1=parseInt(prompt("Adja meg az 1. számot: "))
var szam1_2=parseInt(prompt("Adja meg a 2. számot: "))
var szam1_3=parseInt(prompt("Adja meg a 3. számot: "))

if(szam1_1>=szam1_2 && szam1_1>=szam1_3 && szam1_2>=szam1_3)
{
    console.log(szam1_1,szam1_2,szam1_3)
}
else if(szam1_1>=szam1_2 && szam1_1>=szam1_3 && szam1_2<=szam1_3)
{
    console.log(szam1_1,szam1_3,szam1_2)
}
else if(szam1_1<=szam1_2 && szam1_1>=szam1_3 && szam1_2>=szam1_3)
{
    console.log(szam1_2,szam1_1,szam1_3)
}
else if(szam1_1<=szam1_2 && szam1_1<=szam1_3 && szam1_2>=szam1_3)
{
    console.log(szam1_2,szam1_3,szam1_1)
}
else if(szam1_1>=szam1_2 && szam1_1<=szam1_3 && szam1_2<=szam1_3)
{
    console.log(szam1_3,szam1_1,szam1_2)
}
else if(szam1_1<=szam1_2 && szam1_1<=szam1_3 && szam1_2<=szam1_3)
{
    console.log(szam1_3,szam1_2,szam1_1)
}

//2. Feladat
for (let i=60;i>=10;i--)
{
    if(i%2!=0)
    {
        console.log(i)
    }
}

//3. Feladat
var szam3_1=parseInt(prompt("Adjon meg egy egész számot: "))
if(szam3_1%2==0)
{
    console.log("A szám páros!")
}
else
{
    console.log("A szám páratlan!")
}

//4. Feladat
var szam4_1=parseInt(prompt("Adja meg az 1. számot: "))
var szam4_2=parseInt(prompt("Adja meg a 2. számot: "))
var szam4_3=parseInt(prompt("Adja meg a 3. számot: "))
if(szam4_1<=szam4_2 && szam4_1<=szam4_3)
{
    console.log(szam4_1)
}
else if(szam4_2<=szam4_1 && szam4_2<szam4_3)
{
    console.log(szam4_2)
}
else
{
    console.log(szam4_3)
}

//5. Feladat
do
{
    szam5_1=parseInt(prompt("Addjon meg egy számot ]11;37] intervallumban: "))
} while (szam5_1<=11 || szam5_1>37)

//6. Feladat
var a=parseInt(prompt("Addja meg a háromszög a oldalát: "))
var b=parseInt(prompt("Addja meg a háromszög b oldalát: "))
var c=parseInt(prompt("Addja meg a háromszög c oldalát: "))

if(a+b>c  && a+c>b && b+c>a)
{
    console.log("A háromszög szerkeszthető!")
}
else
{
    console.log("A háromszög nem szerkeszthető!")
}


console.log("Siker!")