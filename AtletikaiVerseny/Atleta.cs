using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }


        public void atleta(string sor)
        {
            string[] a = sor.Split(';');
            Rajtszam = a[0];
            VezNev = a[1];
            Egyesulet = a[2];
            Ugras = Convert.ToInt32(a[3]);
        }


        public void Nev(string VezNev)
        {
            string[] Nev = VezNev.Split(' ');
            VezNev = Nev[0];
            KerNev = Nev[1];
        }
    }
}
