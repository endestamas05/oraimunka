using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_22_09_27
{
    class Program
    {
        //Tömb feltöltése eljárással
        public static void tomb_feltoltes(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Adja meg az {i + 1}. elem értékét: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Tömb kiiratása eljárással
        public static void tomb_kiiras(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
        }

        //Lista feltöltése eljárással
        public static void lista_feltoltes(List<int> lista)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Adja meg az {i + 1}. elem értékét: ");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        //Lista kiírása eljárással
        public static void lista_kiiras(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]} ");
            }
        }

        //Lista feltöltése függvénnyel
        public static List<int> lista2_feltoltes()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Adja meg az {i + 1}. elem értékét: ");
                temp.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return temp;
        }
        //Lista összegzése
        public static int lista_osszegzes(List<int> lista)
        {
            int osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg += lista[i];
            }
            return osszeg;
        }


        //1. Feladat
        public static void kartomb_feltoltes(char[] kartomb)
        {
            for (int i = 0; i < kartomb.Length; i++)
            {
                Console.Write($"Adja meg az {i + 1}. elem értékét: ");
                kartomb[i] = Convert.ToChar(Console.ReadLine());
            }
        }
        public static void kartomb_kiiras(char[] kartomb)
        {
            for (int i = 0; i < kartomb.Length; i++)
            {
                Console.Write($"{kartomb[i]} ");
            }
        }

        //2. Feladat
        public static string[] szovegtomb_feltoltes(string[] szovegtomb)
        {
            for (int i = 0; i < szovegtomb.Length; i++)
            {
                Console.Write($"Adja meg az {i + 1}. elem értékét: ");
                szovegtomb[i] = Console.ReadLine();
            }
            return szovegtomb;
        }
        public static void szovegtomb_kiiras(string[] szovegtomb)
        {
            for (int i = 0; i < szovegtomb.Length; i++)
            {
                Console.Write($"{szovegtomb[i]} ");
            }
        }

        //3. Feladat
        public static List<double> valoslista_feltoltes()
        {
            List<double> lista = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Adja meg az {i + 1}. elem értékét: ");
                lista.Add(Convert.ToDouble(Console.ReadLine()));
            }
            return lista;
        }
        public static void valoslista_kiiras(List<double> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]} ");
            }
        }

        //4. Feladat
        public static void logikailista_feltoltes(List<bool> lista)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Adja meg az {i+1}. elem értékét: ");
                lista.Add(Convert.ToBoolean(Console.ReadLine()));
            }
        }

        public static void logikailista_kiiras(List<bool> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]} ");
            }

        }

        //5. Feladat
        public static List<int> egeszlista_feltoltes()
        {
            Random random = new Random();
            int hossz;
            Console.Write("Lista hosszúsága: ");
            hossz = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>();
            for (int i = 0; i < hossz; i++)
            {
                int rnd = random.Next(10, 40);
                lista.Add(Convert.ToInt32(rnd));
            }

            return lista;
        }

        public static void egeszlista_kiiras(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]} ");
            }
        }

        public static int paros_szamok(List<int> lista)
        {
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    db++;
                }
            }
            return db;
        }
        
        public static int paros_szamokosszege(List<int> lista)
        {
            int parososszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    parososszeg+=lista[i];
                }
            }
            return parososszeg;
        }

        public static string nagyobb_szam(List<int> lista)
        {
            int nagyobb = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 38)
                {
                    nagyobb++;
                }
            }
            if (nagyobb > 0)
            {
                return "Van!";
            }
            else
            {
                return "Nincs!";
            }
        }
        public static void oszthato_szam(List<int> lista)
        {
            int oszthato = 0;
            int hely = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 3 == 0)
                {
                    oszthato++;
                    hely = i+1;
                }
            }
            if (oszthato > 0)
            {
                Console.WriteLine("Van 3-al osztható szám!");
                Console.WriteLine($"\tHelye: {hely}");
            }
            else
            {
                Console.WriteLine("Nincs 3-al osztható szám!");
            }
        }

        public static int max_index(List<int> lista)
        {
            int max_h = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[max_h]<lista[i])
                {
                    max_h = i;
                }
            }
            return max_h;
        }

        public static int min_szam(List<int> lista)
        {
            int min_szam = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (min_szam > lista[i])
                {
                    min_szam = lista[i];
                }
            }
            return min_szam;
        }

        public static double paros_szamokatlaga(List<int> lista)
        {
            int db = 0;
            int osszeg=0;
            int atlag;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    db++;
                    osszeg +=lista[i];
                }
            }
            atlag = osszeg / db;
            return atlag;
        }

        static void Main(string[] args)
        {
            /*
            int[] tomb = new int[10];
            tomb_feltoltes(tomb);
            tomb_kiiras(tomb);

            Console.WriteLine("");

            List<int> lista = new List<int>();
            lista_feltoltes(lista);
            lista_kiiras(lista);

            Console.WriteLine("");

            List<int> lista2 = lista2_feltoltes();
            lista_kiiras(lista2);

            Console.WriteLine("");

            Console.WriteLine($"Összeg: {lista_osszegzes(lista)}");

            Console.WriteLine("");
            */
            /*
             * 1. Feladat:
                - Hozzon létre egy karakter tömböt, majd töltse fel eljárás segítségével 3 darab karakterrel. Írja ki eljárás segítségével a karakter tömb tartalmát.
              
             * 2. Feladat:
                - Hozzon létre egy szöveg tömböt, majd töltse fel függvény segítségével 2 darab értékkel. Írja ki eljárás segítségével a szöveg tömb tartalmát.
              
             * 3. Feladat:
                - Hozzon létre egy valós listát, majd töltse fel függvény segítségével 5 darab értékkel. Írja ki eljárás segítségével a valós lista tartalmát.
              
             * 4. Feladat:
                - hozzon létre egy logikai listát, majd töltse fel eljárás segítségével 7 darab értékkel. Írja ki eljárás segítségével a logikai lista tartalmát.
             * 5. Feladat:
                - Hozzon létre egy egész típusú listát. Készítsen egy függvényt, amely az egész listát fogja feltölteni.
                - A függvény feladata:
	            - Olvassa be a felhasználótól, hogy hány darab elemmel töltse fel a listát, majd töltse fel a listát annyi darab random számmal. A random szám a [10, 39[ intervallum alapján legyen feltöltve.
                - Eljárás segítségével írja ki a lista tartalmát konzolra.
                - Függvény segítségével határozza meg, hogy hány darab páros szám van a listában.
                - Függvény segítségével határozza meg a páros számok összegét.
                - Függvény segítségével határozza meg, hogy van-e 38-nál nagyobb szám.
                - Eljárás segítségével határozza meg, hogy van-e 3-al osztható szám a listában, majd pedig ha van írja ki annak a helyét.
                - Függvény segítségével határozza meg a legnagyobb szám indexét.
                - Függvény segítségével határozza meg a legkisebb szám értékét.
                - Függvény segítségével határozza meg a páros számok átlagát.
            */
            /*
            //1. Feladat:
            Console.WriteLine("Karaktertömb:");
            char[] kartomb = new char[3];
            kartomb_feltoltes(kartomb);
            kartomb_kiiras(kartomb);

            Console.WriteLine("");
            */
            //2. Feladat
            Console.WriteLine("Szövegtömb:");
            string[] szovegtomb = new string[2];
            szovegtomb_feltoltes(szovegtomb);
            szovegtomb_kiiras(szovegtomb);

            Console.WriteLine("");

            //3. Feladat
            Console.WriteLine("Valós lista:");
            List<double> valoslista = valoslista_feltoltes();
            valoslista_kiiras(valoslista);
            
            Console.WriteLine("");

            //4. Feladat
            Console.WriteLine("Logikai lista:");
            List<bool> logikai_lista = new List<bool>();
            logikailista_feltoltes(logikai_lista);
            logikailista_kiiras(logikai_lista);
            
            Console.WriteLine("");
            
            //5. Feladat
            Console.WriteLine("Egész típusú lisita:");
            List<int> egesz_lista = egeszlista_feltoltes();
            egeszlista_kiiras(egesz_lista);
            
            Console.WriteLine("");

            Console.WriteLine($"Páros számok: {paros_szamok(egesz_lista)}");
            Console.WriteLine($"Páros számok összege: {paros_szamokosszege(egesz_lista)}");
            Console.WriteLine($"Van-e 38-nál nagyob szám? {nagyobb_szam(egesz_lista)}");
            oszthato_szam(egesz_lista);
            Console.WriteLine($"Legnagyobb szám indexe: {max_index(egesz_lista)}");
            Console.WriteLine($"Legkissebb szám: {min_szam(egesz_lista)}");
            Console.WriteLine($"Páros számok átlaga: {paros_szamokatlaga(egesz_lista)}");

            Console.ReadKey();
        }
    }
}
