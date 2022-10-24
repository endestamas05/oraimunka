using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak
{
    //5.Feladat
    class Program
    {
        public static List<int> egesz_listafeltoltes()
        {
            Random random = new Random();
            List<int> lista = new List<int>();
            int hossz;
            Console.Write("Adja meg a lista hosszúságát: ");
            hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz; i++)
            {
                int rnd = random.Next(10, 40);
                lista.Add(Convert.ToInt32(rnd));
            }
            return lista;
        }
        public static void egesz_listakiiras(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]} ");
            }
        }

        public static int paros_szamdb(List<int> lista)
        {
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                    db++;
            }
            return db;
        }

        public static int paros_szamosszeg(List<int> lista)
        {
            int osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                    osszeg+=lista[i];
            }
            return osszeg;
        }

        public static string nagyobb_szam(List<int> lista)
        {
            int db = 0;
            while(db<lista.Count && lista[db]<38)
            {
                db++;
            }
            if (db < lista.Count)
            {
                return "\tVan 38-nál nagyobb szám!";
            }
            else
            {
                return "\tNincs 38-nál nagyobb szám!";
            }
        }

        public static void oszthato_szam(List<int> lista)
        {
            int db = 0;
            while (db < lista.Count && lista[db] % 3 !=0)
            {
                db++;
            }
            if (db < lista.Count)
            {
                Console.WriteLine($"\tVan 3-al osztható szám! Indexe: {db}");
            }
            else
            {
                Console.WriteLine("\tNincs 3-al osztható szám!");
            }
        }

        public static int legkisseb_szam(List<int> lista)
        {
            int min_sz = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (min_sz > lista[i])
                {
                    min_sz = lista[i];
                }
            }
            return min_sz;
        }

        public static int legnagyobb_index(List<int> lista)
        {
            int index = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[index] < lista[i])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int paros_atlag(List<int> lista)
        {
            int osszeg = 0;
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    osszeg += lista[i];
                    db++;
                }
            }
            int atlag = osszeg / db;
            return atlag;
        }
        static void Main(string[] args)
        {


            //5. Feladat
            Console.WriteLine("Egész lista:");
            List<int> egesz_lista = egesz_listafeltoltes();
            egesz_listakiiras(egesz_lista);

            Console.WriteLine();

            Console.WriteLine($"\tPáros számok a lisstában: {paros_szamdb(egesz_lista)}db");
            Console.WriteLine($"\tPáros számok összege: {paros_szamosszeg(egesz_lista)}");
            Console.WriteLine(nagyobb_szam(egesz_lista));
            oszthato_szam(egesz_lista);
            Console.WriteLine($"\tLegnagyobb szám indexe: {legnagyobb_index(egesz_lista)}");
            Console.WriteLine($"\tLegkissebb szám értéke: {legkisseb_szam(egesz_lista)}");
            Console.WriteLine($"\tPáros számok átlaga: {paros_atlag(egesz_lista)}");

            Console.ReadKey();
        }
    }
}
