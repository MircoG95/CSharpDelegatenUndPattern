using System;

namespace Delegaten_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action: ohne Rückgabewert, bis zu 16 Parameter
            Action<bool> a1 = Anzeigen;
            a1(true);
            a1(false);
            Console.WriteLine();

            Action a2 = Ausgabe;
            a2();

        }
        static void Ausgabe()
        {
            Console.WriteLine("Hallo");
        }
        static void Anzeigen(bool b)
        {
            if (b)
                Console.WriteLine("Ist true.");
            else
                Console.WriteLine("Ist false.");
        }
    }
}
