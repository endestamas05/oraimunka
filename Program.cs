using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak
{
    class Program
    {
        //1. Feladat

        //a.)
        public struct teglalap
        {
            public double aoldal;
            public double boldal;
            public teglalap(double aoldal, double boldal)
            {
                this.aoldal = aoldal;
                this.boldal = boldal;
            }
        }

        //b.)
        public static List<teglalap> feltoltes1()
        {
            List<teglalap> temp = new List<teglalap>();
            for (int i = 0; i < 10; i++)
            {
                teglalap seged;
                Console.Write("Adja meg a téglalap a oldalát: ");
                seged.aoldal = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg a téglalap b oldalát: ");
                seged.boldal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras1(List<teglalap> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"A oldala: {temp[i].aoldal} | B oldala: {temp[i].boldal}");
            }
        }

        //d.)
        public static List<double> kerulet1(List<teglalap> temp)
        {
            List<double> seged = new List<double>();
            for (int i = 0;i<temp.Count;i++)
            {
                seged.Add(temp[i].aoldal * 2 + temp[i].boldal * 2);
            }
            return seged;
        }

        //e.)
        public static List<double> terulet1(List<teglalap> temp)
        {
            List<double> seged = new List<double>();
            for (int i = 0; i < temp.Count; i++)
            {
                seged.Add(temp[i].aoldal * temp[i].boldal);
            }
            return seged;
        }

        //2. Feladat

        //a.)
        public struct kosar
        {
            public string nev;
            public int pont;
            public kosar(string nev, int pont)
            {
                this.nev = nev;
                this.pont = pont;
            }
        }

        //b.)
        public static List<kosar> feltoltes2()
        {
            List<kosar> temp = new List<kosar>();
            for (int i = 0; i < 5; i++)
            {
                kosar seged;
                Console.Write("Addja meg a kosárcsapat nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write("Addja meg a kosárcsapat pontszámát: ");
                seged.pont = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras2(List<kosar> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"Kosárcsapat neve: {temp[i].nev} | Pontszáma: {temp[i].pont}");
            }
        }

        public static string maxpont(List<kosar> temp)
        {
            int max_h = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[max_h].pont < temp[i].pont)
                {
                    max_h = i;
                }
            }
            return temp[max_h].nev;
        }
        
        //3. Feladat

        //a.)
        public struct tanulo
        {
            public string nev;
            public int osztaly;
            public int kor;
            public double atlag;
            public tanulo(string nev, int osztaly, int kor, double atlag)
            {
                this.nev = nev;
                this.osztaly = osztaly;
                this.kor = kor;
                this.atlag = atlag;
            }
        }

        //b.)
        public static List<tanulo> feltoltes3()
        {
            List<tanulo> temp = new List<tanulo>();
            for (int i = 0; i < 3; i++)
            {
                tanulo seged;
                Console.Write("Adja meg a tanuló nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a tanuló osztályát: ");
                seged.osztaly = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg a tanuló korát: ");
                seged.kor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg a tanuló átlagát: ");
                seged.atlag = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras3(List<tanulo> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"A tanuló neve: {temp[i].nev} | Oszálya: {temp[i].osztaly} | Kora: {temp[i].kor} | Átlaga: {temp[i].atlag}");
            }
        }

        //d.)
        public static double atlag10_3(List<tanulo> temp)
        {
            double osszeg = 0;
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].osztaly == 10)
                {
                    osszeg += temp[i].atlag;
                    db++;
                }
            }
            return osszeg / db;
        }

        //e.)
        public static string minatlag3(List<tanulo> temp)
        {
            int min_e = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[min_e].atlag > temp[i].atlag)
                {
                    min_e = i;
                }
            }
            return temp[min_e].nev;
        }

        //f.)
        public static double atlagkor3(List<tanulo> temp)
        {
            double osszeg = 0;
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                osszeg += temp[i].kor;
                db++;
            }
            return osszeg / db;
        }
        
        //4. Feladat
        
        //a.)
        public struct auto
        {
            public string tipus;
            public string rendszam;
            public double fogyasztas;
            public double uzemanyagszint;
            public auto(string tipus, string rendszam, double fogyasztas, double uzemanyagszint)
            {
                this.tipus = tipus;
                this.rendszam = rendszam;
                this.fogyasztas = fogyasztas;
                this.uzemanyagszint = uzemanyagszint;
            }
        }

        //b.)
        public static List<auto> feltoltes4()
        {
            List<auto> temp = new List<auto>();
            for (int i = 0; i < 6; i++)
            {
                auto seged;
                Console.Write("Adja meg az autó típusát: ");
                seged.tipus = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg az autó rendszámát: ");
                seged.rendszam = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg az autó fogyasztását (100 km-en): ");
                seged.fogyasztas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg az autó üzemanyagszintjét: ");
                seged.uzemanyagszint = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras4(List<auto> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"Autó típusa: {temp[i].tipus} | Rendszáma: {temp[i].rendszam} | Fogyasztása: {temp[i].fogyasztas} | Üzemanyagszintje: {temp[i].uzemanyagszint}");
            }
        }

        //d.)
        public static void valaszt4(List<auto> temp)
        {
            string rendszam;
            Console.Write("Adja meg az autó rendszámát: ");
            rendszam = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            int j = 0;
            while (j < temp.Count && rendszam != temp[j].rendszam)
            {
                j++;
            }
            if (j < temp.Count)
            {
                int km;
                Console.Write("Adja meg az utazni kívánt kilométert: ");
                km = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                double tavolsag = temp[j].uzemanyagszint / (temp[j].fogyasztas / 100);
                if (km <= tavolsag) 
                {
                    Console.WriteLine("Képes megtenni a kívánt távolságot!");
                }
                else
                {
                    Console.WriteLine("Nem képes megtenni a kívánt távolságot!");
                }

            }
            else
            {
                Console.WriteLine("Nincs ilyen rendszámú autó!");
            }
        }
        
        //5. Feladat

        //a.)
        public struct mozi
        {
            public string film;
            public string nev;
            public int maxhely;
            public int szabadhely;
            public mozi(string film, string nev, int maxhely, int szabadhely)
            {
                this.film = film;
                this.nev = nev;
                this.maxhely = maxhely;
                this.szabadhely = szabadhely;
            }
        }

        //b.)
        public static List<mozi> feltoltes5()
        {
            List<mozi> temp = new List<mozi>();
            for (int i = 0; i < 6; i++)
            {
                mozi seged;
                Console.Write("Adja meg a film címét: ");
                seged.film = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a mozi nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a mozi maximum férőhelyét: ");
                seged.maxhely = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg a mozi szabad férőhelyeit: ");
                seged.szabadhely = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras5(List<mozi> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"Film címe: {temp[i].film} | Mozi neve: {temp[i].nev} | Max fétőhelyek: {temp[i].maxhely} | Szabadhelyek: {temp[i].szabadhely}");
            }
        }

        //d.)
        public static string min5(List<mozi> temp)
        {
            int min_e = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[min_e].maxhely > temp[i].maxhely)
                {
                    min_e = i;
                }
            }
            return temp[min_e].nev;
        }

        public static string max5(List<mozi> temp)
        {
            int max_e = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[max_e].maxhely < temp[i].maxhely)
                {
                    max_e = i;
                }
            }
            return temp[max_e].nev;
        }

        //e.)
        public static void vasarlas5(List<mozi> temp)
        {
            string cim;
            Console.Write("Adja meg a megnézni kívánt film címét: ");
            cim = Convert.ToString(Console.ReadLine());
            int j = 0;
            while (j < temp.Count && cim != temp[j].film)
            {
                j++;
            }
            if(j<temp.Count)
            {
                int szemelyek;
                Console.Write("Adja meg hány jegyet akar venni: ");
                szemelyek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (szemelyek <= temp[j].szabadhely)
                {
                    Console.WriteLine("Van elég szabad hely!");
                }
                else
                {
                    Console.WriteLine("Nincs elég szabad hely!");
                }
            }
            else
            {
                Console.WriteLine("Ilyen című filmet nem vetítenek!");
            }
        }
        
        //6. Feladat

        //a.)
        public struct termek
        {
            public string nev;
            public int ar;
            public int raktaron;
            public termek(string nev, int ar, int raktaron)
            {
                this.nev = nev;
                this.ar = ar;
                this.raktaron = raktaron;
            }
        }

        //b.)
        public static List<termek> feltoltes6()
        {
            List<termek> temp = new List<termek>();
            for (int i = 0; i < 1; i++)
            {
                termek seged;
                Console.Write("Adja meg a termék nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a termék árát: ");
                seged.ar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg mennyi van raktáron: ");
                seged.raktaron = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras6(List<termek> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"Termék neve: {temp[i].nev} | Ára: {temp[i].ar} | Raktáron: {temp[i].raktaron}");
            }
        }

        //d.)
        public static void vasarlas6(List<termek> temp)
        {
            string nev;
            Console.Write("Adja meg a vásárolni kívánt termék nevét: ");
            nev = Convert.ToString(Console.ReadLine());
            int j = 0;
            while (j < temp.Count && nev != temp[j].nev)
            {
                j++;
            }
            if (j < temp.Count)
            {
                int penz;
                int db;
                Console.Write("Adja meg mennyi pénze van: ");
                penz = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg hány darabot akar venni: ");
                db = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int fizetendo = temp[j].ar * db;
                if (db <= temp[j].raktaron)
                {
                    Console.WriteLine("Van elég termék raktáron!");
                }
                else
                {
                    Console.WriteLine("Nincs elég termék raktáron!");
                }
                if (penz >= fizetendo)
                {
                    Console.WriteLine("Van elég pénze!");
                }
                else
                {
                    Console.WriteLine("Nincs elég pénze!");
                }
            }
            else
            {
                Console.WriteLine("Ilyen című filmet nem vetítenek!");
            }
        }

        static void Main(string[] args)
        {
            //1. Feladat

            //b.)
            List<teglalap> lista1 = feltoltes1();

            //c.)
            kiiras1(lista1);
            Console.WriteLine();

            //d.)
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine($"{i+1}. tégalap kerülete: {kerulet1(lista1)[i]}");
            }
            Console.WriteLine();

            //e.)
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine($"{i+1}. téglap területe: {terulet1(lista1)[i]}");
            }
            Console.WriteLine();

            //2. Feladat

            //b.)
            List<kosar> lista2 = feltoltes2();

            //c.)
            kiiras2(lista2);
            Console.WriteLine();

            //d.)
            Console.WriteLine($"A legtöbb ponttal rendelkező csapat: {maxpont(lista2)}");
            Console.WriteLine();
            
            //3. Feladat

            //b.)
            List<tanulo> lista3 = feltoltes3();

            //c.)
            kiiras3(lista3);
            Console.WriteLine();

            //d.)
            Console.WriteLine($"A tizedikes osztály átlaga: {atlag10_3(lista3)}");
            Console.WriteLine();

            //e.)
            Console.WriteLine($"A leggyengébb tanuló: {minatlag3(lista3)}");
            Console.WriteLine();

            //f.)
            Console.WriteLine($"A tanulók átlag életkora: {atlagkor3(lista3)}");
            Console.WriteLine();
            
            //4. Feladat

            //b.)
            List<auto> lista4 = feltoltes4();

            //c.)
            kiiras4(lista4);
            Console.WriteLine();

            //d.)
            valaszt4(lista4);
            Console.WriteLine();
            
            //5. Feladat

            //b.)
            List<mozi> lista5 = feltoltes5();

            //c.)
            kiiras5(lista5);
            Console.WriteLine();

            //d.)
            Console.WriteLine($"A legkevesebb hellyel rendelkezö mozi neve: {min5(lista5)}");
            Console.WriteLine($"A legtöbb hellyel rendelkezö mozi neve: {max5(lista5)}");
            Console.WriteLine();

            //e.)
            vasarlas5(lista5);
            
            //6. Feladat

            //b.)
            List<termek> lista6 = feltoltes6();

            //c.)
            kiiras6(lista6);
            Console.WriteLine();

            //d.)
            vasarlas6(lista6);

            Console.ReadKey();
        }
    }
}