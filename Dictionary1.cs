using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Dictionary1
{
    internal class Program
    {

        //3. Feladat
        public static Dictionary<string, string> beolvas3()
        {
            FileStream fs = new FileStream("cimek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            Dictionary<string, string> temp = new Dictionary<string, string>();

            while(!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                temp.Add(
                    sor.Split(';')[1],
                    sor.Split(';')[0]
               );
            }

            sr.Close();
            fs.Close();
            return temp;
        }

        //4. Feladat

        //a.)
        public static Dictionary<string, string> beolvas4()
        {
            FileStream fs = new FileStream("ebed.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            Dictionary<string, string> temp = new Dictionary<string, string>();

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                if(temp.ContainsKey(sor.Split(';')[0]) || temp.ContainsKey(sor.Split(';')[1])) {}
                else
                {
                    temp.Add(sor.Split(';')[0], sor.Split(';')[1]);
                }
            }

            sr.Close();
            fs.Close();
            return temp;
        }

        //b.)
        public struct ebed
        {
            public string nev;
            public string osztaly;
            public ebed(string nev, string osztaly)
            {
                this.nev = nev;
                this.osztaly = osztaly;
            }
        }

        public static List<ebed> feltoltes4()
        {
            List<ebed> temp = new List<ebed>();

            for (int i = 0; i < 3; i++)
            {
                ebed seged;
                Console.Write($"Adja meg a(z) {i+1}. diák nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. diák osztályát: ");
                seged.osztaly = Convert.ToString(Console.ReadLine());
                temp.Add(seged);
            }

            return temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n1. Feladat");
            Random random = new Random();
            //1. Feladat
            Dictionary<string, int> szotar1 = new Dictionary<string, int>()
            {
                {"alma", 2}, {"körte", 3}, {"barack", 10}, {"ribizli", 4}
            };

            foreach (KeyValuePair<string, int> item in szotar1)
            {
                Console.WriteLine($"Szó: {item.Key} Darabszám: {item.Value}");
            }


            //2. Feladat
            Console.WriteLine("\n2. Feladat");

            Dictionary<int, int> dobokocka1 = new Dictionary<int, int>();
            for (int i = 0; i < 100; i++)
            {
                int rnd = random.Next(1,7);
                if (dobokocka1.ContainsKey(rnd))
                {
                    dobokocka1[rnd]++;
                }
                else
                {
                    dobokocka1.Add(rnd, 1);
                }
            }

            foreach (KeyValuePair<int, int> item in dobokocka1)
            {
                Console.WriteLine($"Dobás: {item.Key} Darabszám: {item.Value}");
            }

            //3. Feladat
            Console.WriteLine("\n3. Feladat");

            Dictionary<string, string> szotar3 = beolvas3();

            foreach (KeyValuePair<string, string> item in szotar3)
            {
                Console.WriteLine($"Név: {item.Value} | E-mail: {item.Key}");
            }

            Console.Write("Adjon meg egy E-mail címet: ");
            string keres3=Console.ReadLine();

            //c.)
            if (szotar3.ContainsKey(keres3))
            {
                Console.WriteLine($"Van ilyen E-mail: {szotar3[keres3]}\n");
            }
            else
            {
                Console.WriteLine("Nincs ilye E-mail cím!\n");
            }

            //d.)
            foreach (string item in szotar3.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //e.)
            foreach (string item in szotar3.Values)
            {
                Console.WriteLine(item);
            }
            
            //4. Feladat

            //a.)
            Dictionary<string, string> osztalyok4 = beolvas4();

            foreach (KeyValuePair<string, string> item in osztalyok4)
            {
                Console.WriteLine($"Név: {item.Key} | osztály: {item.Value}");
            }

            //b.)
            List<ebed> lista4 = feltoltes4();

            for (int i = 0; i < lista4.Count; i++)
            {
                if (osztalyok4.ContainsKey(lista4[i].nev) /*&& osztalyok4.ContainsValue(lista4[i].osztaly)*/)
                {
                    Console.WriteLine($"{lista4[i].nev} {lista4[i].osztaly}-osztályos tauló be van fizetve!");
                }
                else
                {
                    Console.WriteLine($"{lista4[i].nev} {lista4[i].osztaly}-osztályos tauló nincs be fizetve!");
                }
            }


            Console.ReadKey();
        }
    }
}
