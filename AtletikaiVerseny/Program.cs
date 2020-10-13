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
                Atletak.Add(Atleta(sr.ReadLine()));
            }
            sr.Close();
        }


        static void Main(string[] args)
        {
            Beolvasas();


            Console.ReadKey();
        }
    }
}
