import os

os.system("cls")
#teljes állomány -> string típus
"""be=open("szuletes.txt","r",encoding="utf-8")
text=be.read()
be.close()
print(text)
textlist=text.split("\n")
print(textlist)"""
#az állomány első karaktere -> string típus
"""be=open("szuletes.txt","r",encoding="utf-8")
text=be.read(23)
be.close()
print(text)
textlist=text.split("\n")
print(textlist)"""
#az állomány első sora -> string típus
"""be=open("szuletes.txt","r",encoding="utf-8")
line=be.readline()
be.close()
print(line)"""
#az állomás összes sora -> string lista
"""be=open("szuletes.txt","r",encoding="utf-8")
lines=be.readlines()
be.close()
print(lines)
for i in range(0,len(lines),1):
    lines[i]=lines[i].strip()
print(lines)"""
#beolvasás 2d listába
szemelyek=[]
be=open("szuletes.txt","r",encoding="utf-8")
for sor in be:
    sor=sor.strip().split(" ")
    sor[2]=int(sor[2])
    szemelyek.append(sor)
be.close()
for i in range(0,len(szemelyek),1):
    for j in range(0,3,1):
        print(szemelyek[i][j],end=" ")
    print("")
#kiírás
ki=open("adatok.txt","w",encoding="utf-8")
print(szemelyek[1][1],file=ki)
ki=open("adatok.txt","a",encoding="utf-8")
print(szemelyek[0][1],file=ki)
ki.close()