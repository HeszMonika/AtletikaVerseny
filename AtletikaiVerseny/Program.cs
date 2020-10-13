using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> Atletak = new List<Atleta>();


        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("tavol.csv");
            while (!sr.EndOfStream)
            {
                Atletak.Add(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine("1. feladat: adatok beolvasása");
        }


        static void MasodikFeladat()
        {
            foreach (var a in Atletak)
            {
                Console.WriteLine("2. feladat: Nevek és ugrások");
                Console.WriteLine(a.VezNev, a.KerNev, a.Ugras);
            }
        }


        static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat: Egyesületek");
            foreach (var a in Atletak)
            {
                int x = a.Egyesulet.Count();
                Console.WriteLine($"{a.Egyesulet}");
            }
        }


        static void NegyedikFeladat()
        {
            int max = 0;
            foreach (var a in Atletak)
            {
                if (max < a.Ugras)
                {
                    max = a.Ugras;
                }
            }

            foreach (var a in Atletak)
            {
                if (max == a.Ugras)
                {
                    Console.WriteLine($"4. feladat: Legnagyobb ugrás: {a.VezNev} {a.KerNev}: {a.Ugras} cm.");
                }
            }
        }


        static void OtodikFeladat()
        {
            double szum = 0;
            double atlag = 0;
            int db = 0;
            foreach (var a in Atletak)
            {
                szum = szum + a.Ugras;
            }

            foreach (var a in Atletak)
            {
                atlag = szum / 9;
            }

            foreach (var a in Atletak)
            {
                if (a.Ugras < atlag)
                {
                    db++;
                }
            }
            Console.WriteLine("5. feladat: Átlag alatt lévő ugrások száma: {0}", db);
        }


        static void HatodikFeladat()
        {
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            foreach (var a in Atletak)
            {
                sw.WriteLine($"{a.Rajtszam}; {a.VezNev} {a.KerNev}");
            }
            sw.Close();
            Console.WriteLine("6. feladat: Adatok fájlba írása");
        }


        static void Main(string[] args)
        {
            Beolvasas();
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();


            Console.ReadKey();
        }
    }
}
