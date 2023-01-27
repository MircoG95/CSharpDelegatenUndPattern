using System;
using System.Collections.Generic;

namespace Pattern_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Tisch t1 = new Tisch();
            t1.Farbe = "Rot";
            t1.Groesse = "M";
            t1.Material = "Holz";
            t1.Design = new Vintage();

            t1.Dispose();

            //Garbage Collector:
            //Zur Löschung markiert
            //Ebene 1: alle 2-5 Sekunden
            //Ebene 2: nicht zu löschende Variablen aus Tier 1, wird weniger kontrolliert
            //Ebene 3: nicht zu löschende Variablen aus Tier 2, wird noch weniger kontrolliert

        }
    }
}
