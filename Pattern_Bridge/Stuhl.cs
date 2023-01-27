using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Bridge
{
    class Stuhl : Moebel
    {
        public override void MoebelErstellen()
        {
            Console.WriteLine("Stuhl wurde erstellt.");
        }
    }
}
