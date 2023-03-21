using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feladat_23_02_28
{
    class Program
    {
        //1. Feladat
        public static void register1()
        {
            FileStream fs = new FileStream("users.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            List<string> seged = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                string username;
                string password;
                string pass2;
                bool van;

                if (i == 0)
                {
                    Console.Write($"Adjon meg az {i + 1}. felhasználónevet: ");
                    username = Convert.ToString(Console.ReadLine());
                    seged.Add(username);
                }
                else
                {
                    do
                    {
                        Console.Write($"Adjon meg a(z) {i + 1}. felhasználónevet: ");
                        username = Convert.ToString(Console.ReadLine());
                        int j = 0;
                        while (j < seged.Count && seged[j] == username)
                        {
                            j++;
                        }
                        if (j < seged.Count)
                        {
                            seged.Add(username);
                            van = false;
                        }
                        else
                        {
                            van = true;
                            Console.Write($"Ez a felhasználónév már létezik, adjon meg egy másikat!\n\t");
                        }
                    } while (van != false);
                }

                
                
                Console.Write("Adjon meg egy jelszót: ");
                password = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a jelszót ismét: ");
                pass2 = Convert.ToString(Console.ReadLine());
                if (password != pass2)
                {
                    Console.WriteLine("A jelszók nem egyeznek!");
                    do
                    {
                        Console.Write("\tAdja meg újra a jelszót: ");
                        password = Convert.ToString(Console.ReadLine());
                        Console.Write("\tAdja meg a jelszót ismét: ");
                        pass2 = Convert.ToString(Console.ReadLine());
                    } while (password != pass2);

                    sw.WriteLine(username + ";" + password);
                }
                else
                {
                    sw.WriteLine(username + ";" + password);
                }
                Console.WriteLine();
            }

            sw.Close();
            fs.Close();
        }
        public struct adatok
        {
            public string username;
            public string password;
            public adatok(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
        }

        public static List<adatok> beolvas1()
        {
            List<adatok> temp = new List<adatok>();
            FileStream fs = new FileStream("users.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                temp.Add(new adatok(
                    sor.Split(';')[0],
                    sor.Split(';')[1]
                    ));
            }

            sr.Close();
            fs.Close();
            return temp;
        }

        public static void login1(List<adatok> temp)
        {
            string user;
            string pass;
            bool vane = false;

            do
            {
                Console.Write($"Adja meg a felhasználónevét: ");
                user = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a jelszavát: ");
                pass = Convert.ToString(Console.ReadLine());

                int j = 0;
                while (j < temp.Count && user != temp[j].username)
                {
                    j++;
                }
                if (temp[j].password == pass)
                {
                    vane = true;
                    Console.WriteLine("Sikeres bejelentkezés!");
                }
                else
                {
                    Console.WriteLine("Sikertelen bejelentkezés!\n");
                }
            } while (vane == false);
        }

        //2. Feladat
        public struct tanulo
        {
            public string nev;
            public int kor;
            public double prog_atlag;
            public double mat_atlag;
            public tanulo(string nev, int kor, double prog_atlag, double mat_atlag)
            {
                this.nev = nev;
                this.kor = kor;
                this.prog_atlag = prog_atlag;
                this.mat_atlag = mat_atlag;
            }
        }

        public static List<tanulo> beolvas2()
        {
            List<tanulo> temp = new List<tanulo>();
            int n;
            do
            {
                Console.Write("Mennyi adatot szeretne bevinni a listába ( 5 - 15 közötti számot adjon meg)? ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 5 || n > 15);
            
            for (int i = 0; i < n; i++)
            {
                tanulo seged;
                Console.Write("Adja meg a tanuló nevét: ");
                seged.nev = Convert.ToString(Console.ReadLine());
                Console.Write("Adja meg a tanuló korát: ");
                seged.kor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adja meg a tanuló programozás átlagát: ");
                seged.prog_atlag = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg a tanuló matematika átlagát: ");
                seged.mat_atlag = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                temp.Add(seged);
            }
            return temp;
        }

        public static void kiir(List<tanulo> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"Tanuló neve: {temp[i].nev} | Kora: {temp[i].kor} | Programozás átlagja: {temp[i].prog_atlag} | Matematika átlagja: {temp[i].mat_atlag}");
            }
        }

        public static void fajlkiir(List<tanulo> temp)
        {
            FileStream fs = new FileStream("tanulok.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            for (int i = 0; i < temp.Count; i++)
            {
                sw.WriteLine(temp[i].nev + "," + temp[i].kor + "," + temp[i].prog_atlag + "," + temp[i].mat_atlag);
            }

            sw.Close();
            fs.Close();
        }

        public static List<tanulo> beolvas2_2()
        {
            List<tanulo> temp = new List<tanulo>();
            FileStream fs = new FileStream("tanulok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                temp.Add(new tanulo(
                    sor.Split(',')[0],
                    Convert.ToInt32(sor.Split(',')[1]),
                    Convert.ToDouble(sor.Split(',')[2]),
                    Convert.ToDouble(sor.Split(',')[3])
                    ));
            }

            sr.Close();
            fs.Close();
            return temp;
        }

        public static int idosebb18(List<tanulo> temp)
        {
            int db = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].kor >= 18)
                {
                    db++;
                }
            }
            return db;
        }
        public static void progbukas(List<tanulo> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].prog_atlag < 2)
                {
                    Console.Write($"{temp[i].nev} ");
                }
            }
        }
        public static void matbukas(List<tanulo> temp)
        {
            int j = 0;
            while (j < temp.Count && temp[j].mat_atlag >= 2)
            {
                j++;
            }
            if (j < temp.Count)
            {
                Console.WriteLine("Van aki megbukott matematikából!");
            }
            else
            {
                Console.WriteLine("Senki sem bukott meg matematikából!");
            }
        }

        static void Main(string[] args)
        {
            //1. Feladat
            
            register1();
            List<adatok> lista1 = beolvas1();
            login1(lista1);
            
            Console.WriteLine();
            
            //2. Feladat
            List<tanulo> lista2 = beolvas2();
            kiir(lista2);
            fajlkiir(lista2);
            List<tanulo> lista2_2 = beolvas2_2();

            Console.WriteLine($"\n18 évnél idősebb tanulók: {idosebb18(lista2_2)}");
            Console.Write("Megbuktak programozásból: ");
            progbukas(lista2_2);
            Console.WriteLine();
            matbukas(lista2_2);

            Console.ReadKey();
        }
    }
}
