using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_22_09_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!"); //A WriteLine végén autómatikusan sortörés van
            Console.Write("Hello world!"); //A Write végén nincsen sortörés
            Console.WriteLine("<-- Nincs sortörés\n");
            int egesz_szam; // int egesz_szam = 5 
            Console.Write("Adjon meg egy egész számot: ");
            egesz_szam = Convert.ToInt32(Console.ReadLine());
            //1. eset
            //Console.WriteLine("Érték: " + egesz_szam);
            //2. eset
            Console.WriteLine($"Érték: {egesz_szam}\n");

            double valos_szam;
            Console.Write("Adjon meg egy valós számot: ");
            valos_szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Érték: {valos_szam}\n");

            bool logikai_szam;
            Console.Write("Adjon meg egy logikai számot: ");
            logikai_szam = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Érték: {logikai_szam}\n");

            char karakterek;
            Console.Write("Adjon meg egy karaktert: ");
            karakterek = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Érték: {karakterek}\n");

            string szoveg_karakterlanc;
            Console.WriteLine("Adjon meg egy szöveget és egy karakterláncot: ");
            szoveg_karakterlanc = Console.ReadLine();
            Console.WriteLine($"Érték: {szoveg_karakterlanc}\n");

            Console.WriteLine();

            int kor;
            Console.WriteLine("Adja meg az életkorát: ");
            kor = Convert.ToInt32(Console.ReadLine());

            //Egy ágú elágazás
            if (kor >= 18)
            {
                Console.WriteLine("Nagykorú");
            }

            Console.WriteLine();

            //Két tagú elágazás
            if (kor < 18)
            {
                Console.WriteLine("Kiskorú");
            }
            else
            {
                Console.WriteLine("Nagykorú");
            }

            Console.WriteLine();

            //Több ágú elágazás
            if (kor < 18)
            {
                Console.WriteLine("Kiskoró");
            }
            else if (kor == 18)
            {
                Console.WriteLine("18 éves");
            }
            else
            {
                Console.WriteLine("Nagykorú");
            }

            Console.WriteLine();

            int jegy;
            Console.Write("Írjon be egy értéket 1 és 5 között: ");
            jegy = Convert.ToInt32(Console.ReadLine());
            //Több ági elágazás
            //Csak abban az esetben használjuk, hogyha egyenlőség vizsgálatot szeretnénk
            switch (jegy) //(változó_név)
            {
                //case érték; utasítás; break;
                //Az érték helyére helyettesítjük be azt az értéket amit a változóhoz hasonlítunk
                //A break; utasítás jelzi az adott  case végét. A break; nélkül minden lefutna.
                case 1: Console.WriteLine("Elégtelen"); break;
                case 2: Console.WriteLine("Elégséges"); break;
                case 3: Console.WriteLine("Közepes"); break;
                case 4: Console.WriteLine("Jó"); break;
                case 5: Console.WriteLine("Jeles"); break;
                //default elhagyható - ez felel meg az else-nek
                default:
                    Console.WriteLine("Nem megfelelő értéket adott meg.");
                    break;
            }

            /*
             Feladat: Mind a három ciklussal írjuk ki a számokat 10-tól 1-ig
            */

            //Számlálós ciklus:
            Console.WriteLine("\n");
            for (int i=10; i>=1; i--)
            {
                Console.Write($"{i} ");
            }

            //Elöltesztelő ciklus
            Console.WriteLine("\n");
            int j = 10;
            while (j>0)
            {
                Console.Write($"{j} ");
                j--;
            }

            //Hátultesztelő ciklus
            Console.WriteLine("\n");
            int l=10;
            do
            {
                Console.Write($"{l} ");
                l--;
            } while (l>0);

            Console.ReadKey(); //Egy karakter beírására vár
            // egy soros komment
            /* több soros komment */
        }
    }
}
