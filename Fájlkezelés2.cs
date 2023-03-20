using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feladat2
{
    class Program
    {
        //1. Feladat
        public static List<int> beolvas1()
        {
            List<int> temp = new List<int>();
            FileStream fs = new FileStream("szamok.txt", FileMode.Open);
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

        public static void kiiras(List<int> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.Write($"{temp[i]} ");
            }
        }

        public static int osszeg(List<int> temp)
        {
            int osszeg = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                osszeg += temp[i];
            }
            return osszeg;
        }

        public static double parosatlag(List<int> temp)
        {
            int osszes = 0;
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] % 2 == 0)
                {
                    osszes += temp[i];
                    db++;
                }
            }
            double atlag = osszes / db;

            return atlag;
        }

        //2. Feladat
        public static List<int> beolvas2()
        {
            List<int> temp = new List<int>();
            FileStream fs = new FileStream("szamok2.txt", FileMode.Open);
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

        public static int maxsz(List<int> temp)
        {
            int max_e = temp[0];
            for (int i = 0; i < temp.Count; i++)
            {
                if (max_e < temp[i])
                {
                    max_e = temp[i];
                }
            }
            return max_e;
        }

        public static int minsz(List<int> temp)
        {
            int min_e = temp[0];
            for (int i = 0; i < temp.Count; i++)
            {
                if (min_e > temp[i])
                {
                    min_e = temp[i];
                }
            }
            return min_e;
        }

        public static double atlag(List<int> temp)
        {
            int osszes = 0;
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                osszes += temp[i];
                db++;
            }
            double atlag = osszes / db;

            return atlag;
        }

        public static int parosdb(List<int> temp)
        {
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] % 2 == 0)
                {
                    db++;
                }
            }
            return db;
        }

        //3. Feladat
        public static List<int> feltoltes3()
        {
            List<int> temp = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                temp.Add(rnd.Next(10, 66));
            }
            return temp;
        }

        public static void fajlir3(List<int> temp)
        {
            FileStream fs = new FileStream("szamok3.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            for (int i = 0; i < temp.Count; i++)
            {
                sw.WriteLine(temp[i]);
            }
            sw.Close();
            fs.Close();
        }

        public static List<int> beolvas3()
        {
            List<int> temp = new List<int>();
            FileStream fs = new FileStream("szamok3.txt", FileMode.Open);
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

        public static string paratlanvane(List<int> temp)
        {
            int j = 0;
            while (j < temp.Count && temp[j] % 2 != 0)
            {
                j++;
            }
            if (j < temp.Count)
            {
                return "Van!";
            }
            else
            {
                return "Nincs!";
            }
        }

        public static int minh(List<int> temp)
        {
            int min_h = 0;
            for (int i = 1; i < temp.Count; i++)
            {
                if (temp[min_h] > temp[i])
                {
                    min_h = i;
                }
            }
            return min_h;
        }

        public static double paratlanatlag(List<int> temp)
        {
            int osszes = 0;
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] % 2 != 0)
                {
                    osszes += temp[i];
                    db++;
                }
            }
            double atlag = osszes / db;

            return atlag;
        }

        //4. Feladat
        public static List<char> beolvas4()
        {
            List<char> temp = new List<char>();
            FileStream fs = new FileStream("karakterek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            while (!sr.EndOfStream)
            {
                char sor = Convert.ToChar(sr.ReadLine());
                temp.Add(sor);
            }
            sr.Close();
            fs.Close();
            return temp;
        }

        public static void kiiras4(List<char> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.Write($"{temp[i]} ");
            }
        }

        public static string keres4(List<char> temp)
        {
            int j = 0;
            while (j < temp.Count && temp[j] != 'z')
            {
                j++;
            }
            if (j < temp.Count)
            {
                return "Van!";
            }
            else
            {
                return "Nincs!";
            }
        }

        public static string keres4_2(List<char> temp)
        {
            int j = 0;
            while (j < temp.Count && temp[j] != 'y')
            {
                j++;
            }
            if (j < temp.Count)
            {
                return $"Van! Helye: {j}";
            }
            else
            {
                return "Nincs!";
            }
        }

        public static int keres4_3(List<char> temp)
        {
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] == 'a')
                {
                    db++;
                }
            }
            return db;
        }

        //5. Feladat
        public struct Adatok
        {
            public string nev;
            public int kor;
            public double suly;
            public Adatok(string nev, int kor, double suly)
            {
                this.nev = nev;
                this.kor = kor;
                this.suly = suly;
            }
        }

        public static List<Adatok> feltoltes5()
        {
            List<Adatok> temp = new List<Adatok>();
            for (int i = 0; i < 5; i++)
            {
                Adatok seged;
                Console.Write("Adja meg a nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a korát: ");
                seged.kor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg a súlyát: ");
                seged.suly = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        public static void fajlir5(List<Adatok> temp)
        {
            FileStream fs = new FileStream("adatok.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            /*
            for (int i = 0; i < temp.Count; i++)
            {
                sw.WriteLine($"Név: {temp[i].nev} Kor: {temp[i].kor} Súly: {temp[i].suly}");
            }
            */
            for (int i = 0; i < temp.Count; i++)
            {
                sw.WriteLine($"{temp[i].nev} {temp[i].kor} {temp[i].suly}");
            }
            sw.Close();
            fs.Close();
        }

        //6. Feladat
        public static List<int> feltoltes6()
        {
            List<int> temp = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                temp.Add(rnd.Next(10,31));
            }
            return temp;
        }

        public static void bovit6(List<int> temp)
        {
            FileStream fs = new FileStream("szamok4.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            for (int i = 0; i < temp.Count; i++)
            {
                sw.WriteLine(temp[i]);
            }
            sw.Close();
            fs.Close();
        }

        public static List<int> beolvas6()
        {
            List<int> temp = new List<int>();
            FileStream fs = new FileStream("szamok4.txt", FileMode.Open);
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

        static void Main(string[] args)
        {
            //1. Feladat
            List<int> lista1 = beolvas1();
            kiiras(lista1);
            Console.WriteLine($"\nSzámok összege: {osszeg(lista1)}");
            Console.WriteLine($"Páros számok átlaga: {parosatlag(lista1)}");

            Console.WriteLine();

            //2. Feladat
            List<int> lista2 = beolvas2();
            kiiras(lista2);
            Console.WriteLine($"\nLegnagyobb szám: {maxsz(lista2)}");
            Console.WriteLine($"Legkisebb szám: {minsz(lista2)}");
            Console.WriteLine($"Számok átlaga: {atlag(lista2)}");
            Console.WriteLine($"Páros számok: {parosdb(lista2)} db");

            Console.WriteLine();

            //3. Feladat
            List<int> lista3 = feltoltes3();
            kiiras(lista3);
            fajlir3(lista3);
            Console.WriteLine();
            List<int> lista3_2 = beolvas3();
            kiiras(lista3_2);
            Console.WriteLine($"\nSzámok összege: {osszeg(lista3_2)}");
            Console.WriteLine($"Páratlan van-e: {paratlanvane(lista3_2)}");
            Console.WriteLine($"Legnagyobb szám: {maxsz(lista3_2)}");
            Console.WriteLine($"Legkisebb szám: {minsz(lista3_2)}");
            Console.WriteLine($"Legkisebb szám hele: {minh(lista3_2)}");
            Console.WriteLine($"Páros számok: {parosdb(lista3_2)} db");
            Console.WriteLine($"Páratlan számok átlaga: {paratlanatlag(lista1)}");

            Console.WriteLine();

            //4. Feladat
            List<char> lista4 = beolvas4();
            kiiras4(lista4);
            Console.WriteLine($"\nVan-e z krakter: {keres4(lista4)}");
            Console.WriteLine($"Van-e y krakter: {keres4_2(lista4)}");
            Console.WriteLine($"a krakterek: {keres4_3(lista4)} db");

            Console.WriteLine();

            //5. Feladat
            List<Adatok> lista5 = feltoltes5();
            fajlir5(lista5);
            
            Console.WriteLine();
            
            //6. Feladat
            List<int> lista6 = feltoltes6();
            kiiras(lista6);
            bovit6(lista6);
            Console.WriteLine();
            List<int> lista6_2 = beolvas6();
            kiiras(lista6_2);
            Console.WriteLine($"\nSzámok összege: {osszeg(lista6_2)}");

            Console.ReadKey();
        }
    }
}