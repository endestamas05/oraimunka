using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feladat3
{
    class Program
    {
        //1. Feladat
        public struct adatok1
        {
            public string nev;
            public int kor;
            public double suly;
            public bool erettsegi;
            public adatok1(string nev, int kor, double suly, bool erettsegi)
            {
                this.nev = nev;
                this.kor = kor;
                this.suly = suly;
                this.erettsegi = erettsegi;
            }
        }

        public static List<adatok1> beolvasas1()
        {
            List<adatok1> temp = new List<adatok1>();
            FileStream fs = new FileStream("adatok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                temp.Add(new adatok1(
                    sor.Split(';')[0],
                    Convert.ToInt32(sor.Split(';')[1]),
                    Convert.ToDouble(sor.Split(';')[2]),
                    Convert.ToBoolean(sor.Split(';')[3])
                    ));
            }
            sr.Close();
            fs.Close();
            return temp;
        }

        public static void kiiras1(List<adatok1> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"Név: {temp[i].nev} | Kor: {temp[i].kor} | Súly {temp[i].suly} | Érettségi: {temp[i].erettsegi}");
            }
        }

        public static double atlagkor1(List<adatok1> temp)
        {
            int osszeg = 0;
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                osszeg += temp[i].kor;
                db++;
            }
            double atlag = osszeg / db;
            return atlag;
        }

        public static string legnehezebb1(List<adatok1> temp)
        {
            int max_h = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[max_h].suly < temp[i].suly)
                {
                    max_h = i;
                }
            }
            return temp[max_h].nev;
        }

        public static string legkonnyebb1(List<adatok1> temp)
        {
            int min_h = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[min_h].suly > temp[i].suly)
                {
                    min_h = i;
                }
            }
            return temp[min_h].nev;
        }

        public static int erettsegidb1(List<adatok1> temp)
        {
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if(temp[i].erettsegi)
                {
                    db++;
                }
            }
            return db;
        }

        public static void felett1(List<adatok1> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].kor > 35)
                {
                    Console.WriteLine($"Név: {temp[i].nev} | Kor: {temp[i].kor} | Súly {temp[i].suly} | Érettségi: {temp[i].erettsegi}");
                }
            }
        }

        public static string fiatalerettsegi1(List<adatok1> temp)
        {
            int min_h = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[min_h].suly > temp[i].suly && temp[i].erettsegi)
                {
                    min_h = i;
                }
            }
            return temp[min_h].nev;
        }

        //2. Feladat
        public static List<int> beolvasas2()
        {
            List<int> temp = new List<int>();
            FileStream fs = new FileStream("adatok2.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            while (!sr.EndOfStream)
            {
                int sor = Convert.ToInt32(sr.ReadLine());
                temp.Add(sor);
            }
            sr.Close();
            fs.Close();
            return temp;
        }

        public static void kiiras2(List<int> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.Write($"{temp[i]} ");
            }
        }

        public static int osszeg2(List<int> temp)
        {
            int osszeg = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                osszeg += temp[i];
            }
            return osszeg;
        }

        public static void bovit2()
        {
            FileStream fs = new FileStream("adatok2.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine(rnd.Next(0, 101));
            }
            sw.Close();
            fs.Close();
        }

        public static int paratlandb2(List<int> temp)
        {
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] % 2 != 0)
                {
                    db++;
                }
            }
            return db;
        }

        public static int kulonbseg2(List<int> temp)
        {
            int min_e = temp[0];
            int max_e = temp[0];
            for (int i = 1; i < temp.Count; i++)
            {
                if (min_e > temp[i])
                {
                    min_e = temp[i];
                }
            }
            for (int i = 1; i < temp.Count; i++)
            {
                if (max_e < temp[i])
                {
                    max_e = temp[i];
                }
            }
            return max_e-min_e;
        }

        public static void parosir2(List<int> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] % 2 == 0)
                {
                    Console.Write($"{temp[i]} ");
                }
            }
        }

        static void Main(string[] args)
        {
            //1. Feladat
            List<adatok1> lista1 = beolvasas1();
            kiiras1(lista1);

            Console.WriteLine($"\nAz átlag életkor: {atlagkor1(lista1)}");
            Console.WriteLine($"A legnehezebb ember: {legnehezebb1(lista1)}");
            Console.WriteLine($"A legkönnyebb ember: {legkonnyebb1(lista1)}");
            Console.WriteLine($"Érettségivel rendelkezik: {erettsegidb1(lista1)}");

            Console.WriteLine("\n35 év felettiek:");
            felett1(lista1);

            Console.WriteLine($"\nLegfiatalabb érettségivel rendelkező: {fiatalerettsegi1(lista1)}");

            Console.WriteLine();

            //2. Feladat
            List<int> lista2 = beolvasas2();

            kiiras2(lista2);

            Console.WriteLine($"\nSzámok összege: {osszeg2(lista2)}\n");

            bovit2();
            List<int> lista2_2 = beolvasas2();
            
            kiiras2(lista2_2);
            Console.WriteLine($"\nSzámok összege: {osszeg2(lista2_2)}");
            Console.WriteLine($"Páratlan számok: {paratlandb2(lista2_2)}");
            Console.WriteLine($"Legnagyobb és legkissebb szám különbsége: {kulonbseg2(lista2_2)}");

            Console.Write("Páros számok: ");
            parosir2(lista2_2);

            Console.ReadKey();
        }
    }
}
