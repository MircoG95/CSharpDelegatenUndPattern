using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Bridge
{
    class Vintage : Design
    {
        
        public override void AusgabeDesign()
        {
            Console.WriteLine("Ich bin ein Vintage-Design.");
        }
    }
}
