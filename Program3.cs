using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static Ismetles1.Program;

namespace Ismetles1
{
    internal class Program
    {
        //1. Feladat

        //a.)
        public struct oldalak
        {
            public double a_oldal;
            public double b_oldal;

            public oldalak(double a_oldal, double b_oldal)
            {
                this.a_oldal = a_oldal;
                this.b_oldal = b_oldal;
            }
        }

        //b.)
        public static List<oldalak> feltoltes1()
        {
            List<oldalak> temp = new List<oldalak>();
            for (int i = 0; i < 10; i++)
            {
                oldalak seged;
                Console.Write($"Adja meg a lista {i + 1}. téglalap a oldalát: ");
                seged.a_oldal = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Adja meg a lista {i + 1}. téglalap b oldalát:");
                seged.b_oldal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras1(List<oldalak> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"A oldal: {temp[i].a_oldal} | B oldal: {temp[i].b_oldal}");
            }
        }

        //d.)
        public static double kerulet1(oldalak temp)
        {
            double a = temp.a_oldal;
            double b = temp.b_oldal;
            return (a + b) * 2;
        }

        //e.)
        public static double terulet1(oldalak temp)
        {
            double a = temp.a_oldal;
            double b = temp.b_oldal;

            return a * b;
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

        //b
        public static List<kosar> feltoltes2()
        {
            List<kosar> temp = new List<kosar>();
            for (int i = 0; i < 5; i++)
            {
                kosar seged;
                Console.Write($"Adja meg a(z) {i+1}. kosárcsapat nevét: ");
                seged.nev = Console.ReadLine();
                Console.Write($"Adja meg a(z) {i+1}. kosárcsapat pontszámát: ");
                seged.pont = Convert.ToInt32( Console.ReadLine() );
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
                Console.WriteLine($"{i+1}. kosárcsapat neve: {temp[i].nev} | pontszáma: {temp[i].pont}");
            }
        }

        //d.)
        public static void maxpont2(List<kosar> temp)
        {
            int max_h = 0;
            for (int i = 1; i < temp.Count; i++)
            {
                if (temp[max_h].pont < temp[i].pont)
                {
                    max_h = i;
                }
            }

            Console.WriteLine($"\nA legtöbb pontot elért csapat neve: {temp[max_h].nev}");
        }
        
        //3. Feladat

        //a.)
        public struct diakok
        {
            public string nev;
            public int osztaly;
            public int kor;
            public double atlag;

            public diakok(string nev, int osztaly, int kor, double atlag)
            {
                this.nev = nev;
                this.osztaly = osztaly;
                this.kor = kor;
                this.atlag = atlag;
            }
        }

        //b.)
        public static List<diakok> feltoltes3()
        {
            List<diakok> temp = new List<diakok>();
            for (int i = 0; i < 3; i++)
            {
                diakok seged;
                Console.Write($"Adja meg a(z) {i + 1}. tanuló nevét: ");
                seged.nev = Console.ReadLine();
                Console.Write($"Adja meg a(z) {i + 1}. tanuló osztályát: ");
                seged.osztaly = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. tanuló korát: ");
                seged.kor = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. tanuló átlagát: ");
                seged.atlag = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras3(List<diakok> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"{i + 1}. diák neve: {temp[i].nev} | osztálya: {temp[i].osztaly} | kora: {temp[i].kor} | átlaga: {temp[i].atlag}");
            }
        }

        //d.)
        public static double tizesatlag3(List<diakok> temp)
        {
            int db = 0;
            double osszeg = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].osztaly == 10)
                {
                    db++;
                    osszeg += temp[i].atlag;
                }
            }
            return osszeg / db;
        }

        //e.)
        public static void mintanulo3(List<diakok> temp)
        {
            int min_h = 0;
            for (int i = 1; i < temp.Count; i++)
            {
                if (temp[min_h].atlag >= temp[i].atlag)
                {
                    min_h = i;
                }
            }
            Console.WriteLine($"A leggyengébb tanuló {temp[min_h].nev}");
        }

        //f.)
        public static void atlagkor3(List<diakok> temp)
        {
            int osszeg = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                osszeg += temp[i].kor;
            }
            Console.WriteLine($"Átlag életkor: {osszeg / temp.Count}");
        }

        //g.)
        public static void osztalyokdb(List<diakok> temp)
        {
            List<int> osztalyok = new List<int>();

            for (int i = 0; temp.Count > i; i++)
            {
                int j = 0;
                while (j < osztalyok.Count && temp[i].osztaly != osztalyok[j])
                {
                    j++;
                }
                if (j >= osztalyok.Count)
                {
                    osztalyok.Add(temp[i].osztaly);
                }
            }

            Console.WriteLine($"{osztalyok.Count} db különböző osztály van!");
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
            for (int i = 0; i < 1; i++)
            {
                auto seged;
                Console.Write($"Addja meg az {i+1}. autó típusát: ");
                seged.tipus = Convert.ToString(Console.ReadLine());
                Console.Write($"Addja meg az {i + 1}. autó rendszámát: ");
                seged.rendszam = Convert.ToString(Console.ReadLine());
                Console.Write($"Addja meg az {i + 1}. autó fogyasztásást: ");
                seged.fogyasztas = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Addja meg az {i + 1}. autó üzemanyag szintjét: ");
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
                Console.WriteLine($"A(z) {i+1}. autó típusa: {temp[i].tipus} | rendszáma: {temp[i].rendszam} | fogyasztása: {temp[i].fogyasztas} | üzemanyagszintje: {temp[i].uzemanyagszint}");
            }
        }

        //d.)
        public static void autokivalasztas(List<auto> temp)
        {
            string azonosit;
            Console.Write("\nAdja meg az autó rendszámát: ");
            azonosit = Console.ReadLine();
            int j = 0;
            while (j < temp.Count && azonosit != temp[j].rendszam)
            {
                j++;
            }
            if (j < temp.Count)
            {
                double km;
                Console.Write("Adja meg az utazni kívánt kilómétert: ");
                km = Convert.ToDouble(Console.ReadLine());
                double tav = temp[j].uzemanyagszint * temp[j].fogyasztas;
                if (km <= tav)
                {
                    Console.WriteLine("Az autó képes megtenni a távolságot!");
                }
                else
                {
                    Console.WriteLine("Az autó nem képes megtenni a távolságot!");
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
            public string cim;
            public string nev;
            public int maxhely;
            public int szabadhely;

            public mozi(string cim, string nev, int maxhely, int szabadhely)
            {
                this.cim = cim;
                this.nev = nev;
                this.maxhely = maxhely;
                this.szabadhely = szabadhely;
            }
        }

        //b.)
        public static List<mozi> feltoltes5()
        {
            List<mozi> temp = new List<mozi>();
            for (int i = 0; i < 10; i++)
            {
                mozi seged;
                Console.Write($"Adja meg a(z) {i + 1}. film nevét: ");
                seged.cim = Console.ReadLine();
                Console.Write($"Adja meg a(z) {i + 1}. moziterem nevét: ");
                seged.nev = Console.ReadLine();
                Console.Write($"Adja meg a(z) {i + 1}. terem maximális férőhelyét: ");
                seged.maxhely = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. terem szabad férőhelyét: ");
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
                Console.WriteLine($"A(z) {i+1}. moziműsor címe: {temp[i].cim} | terem neve: {temp[i].nev} | Max férőhely: {temp[i].maxhely} | Szabad hely: {temp[i].szabadhely}");
            }
        }

        //d.)

        public static void minterem5(List<mozi> temp)
        {
            int min_e = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[min_e].maxhely > temp[i].maxhely)
                {
                    min_e = i;
                }
            }

            Console.WriteLine($"A legkissebb terem: {temp[min_e].nev}");
        }

        public static void maxterem5(List<mozi> temp)
        {
            int max_e = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[max_e].maxhely < temp[i].maxhely)
                {
                    max_e = i;
                }
            }

            Console.WriteLine($"A legnagyobb terem: {temp[max_e].nev}");
        }

        public static void filmvalaszt5(List<mozi> temp)
        {
            string nev;
            Console.Write("Adja meg a megnézni kívánt film címét: ");
            nev = Console.ReadLine();
            
            int j = 0;
            while (j <= temp.Count && nev == temp[j].cim)
            {
                j++;
            }
            if( j < temp.Count)
            {
                int db;
                Console.Write("Lefoglalni kívánt jegyek: ");
                db = Convert.ToInt32(Console.ReadLine());
                if (db <= temp[j].szabadhely)
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
                Console.WriteLine("Nincs ilyen című film!");
            }
        }
        
        //6. Feladat

        //a.)
        public struct vasar
        {
            public string nev;
            public int ar;
            public int raktar;

            public vasar(string nev, int ar, int raktar)
            {
                this.nev = nev;
                this.ar = ar;
                this.raktar = raktar;
            }
        }

        //b.)
        public static List<vasar> feltoltes6()
        {
            List<vasar> temp = new List<vasar>();
            for (int i = 0; i < 2; i++)
            {
                vasar seged;
                Console.Write($"Adja meg a(z) {i + 1}. termék nevét: ");
                seged.nev = Console.ReadLine();
                Console.Write($"Adja meg a(z) {i + 1}. termék árát: ");
                seged.ar = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. termék raktárkészletét: ");
                seged.raktar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        //c.)
        public static void kiiras6(List<vasar> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"A(z) {i + 1}. termék neve: {temp[i].nev} | Ára: {temp[i].ar} | Raktárkészlet: {temp[i].raktar}");
            }
        }

        //d.)
        public static void vasarlas6(List<vasar> temp)
        {
            string termek;
            Console.Write("Adja meg a vásárolni kívánt termék nevét: ");
            termek = Console.ReadLine();

            int j = 0;
            while (j <= temp.Count && termek == temp[j].nev)
            {
                j++;
            }
            if (j < temp.Count)
            {
                int db;
                int penz;
                Console.Write("Vásárolni kívánt darabszám: ");
                db = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg mennyi pénze van: ");
                penz = Convert.ToInt32(Console.ReadLine());
                int fizetendo = temp[j].ar * db;
                if (db <= temp[j].raktar)
                {
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
                    Console.WriteLine("Nincs elég termék!");
                }
                
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék!");
            }
        }

        static void Main(string[] args)
        {
            
            //1. Feladat
            List<oldalak> lista1 = feltoltes1();

            //c.) (eljárás)
            kiiras1(lista1);

            //d/f.) (függvény)
            Console.WriteLine("\nKerületek: ");
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine($"{i+1}. téglalap kerülete {kerulet1(lista1[i])}");
            }

            //e/f.) (függvény)
            Console.WriteLine("\nTerületek:");
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine($"{i+1}. téglalap területe {terulet1(lista1[i])}");
            }
            
            //2. Feladat

            //b.)
            List<kosar> lista2 = feltoltes2();

            //c.)
            kiiras2(lista2);

            //d.)
            maxpont2(lista2);
            
            //3. Feladat

            //b.)
            List<diakok> lista3 = feltoltes3();

            //c.)
            kiiras3(lista3);

            //d.)
            Console.WriteLine($"Tizedikes osztályosok átlaga: {tizesatlag3(lista3)}");

            //e.)
            mintanulo3(lista3);

            //f.)
            atlagkor3(lista3);

            //g.)
            osztalyokdb(lista3);
            
            //4. Feladat

            //b.)
            List<auto> lista4 = feltoltes4();

            //c.)
            kiiras4(lista4);

            //d.)
            autokivalasztas(lista4);

            //5. Feladat

            //b.)
            List<mozi> lista5 = feltoltes5();

            //c.)
            kiiras5(lista5);

            //d.)
            minterem5(lista5);
            maxterem5(lista5);

            //e.)
            filmvalaszt5(lista5);
            
            //6. Feladat

            //b.)
            List<vasar> lista6 = feltoltes6();

            //c.)
            kiiras6(lista6);

            //d.)
            vasarlas6(lista6);

            Console.ReadKey();
        }
    }
}
