using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Bridge
{
    abstract class Moebel
    {
        //Properties
        public string Groesse { get; set; }
        public string Material { get; set; }
        public string Farbe { get; set; }
        public Design Design { get; set; }

        //Methoden
        public abstract void MoebelErstellen();
    }
}
