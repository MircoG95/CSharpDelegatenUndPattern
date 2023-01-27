using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Bridge
{
    class Tisch : Moebel, IDisposable
    {
        public void Dispose()
        {
            Groesse = null;
            Material = null;
            Farbe = null;
            Design = null;
        }

        public override void MoebelErstellen()
        {
            Console.WriteLine("Der Tisch wurde erstellt");
        }
    }
}
