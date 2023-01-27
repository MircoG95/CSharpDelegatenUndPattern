using System;

namespace Delegaten
{
    public delegate void ErsterDelegat(string s);
    class Program
    {
        static void Main(string[] args)
        {
            //ErsterDelegat aufruf = new ErsterDelegat(Ansage);
            ErsterDelegat aufruf = Ansage;
            ErsterDelegat aufruf2 = null;

            //Verschiedene Aufrufe
            aufruf("Karl");
            aufruf.Invoke("Agathe");

            //Gleicher Aufruf, verschiedene Schreibweise
            if (aufruf2 != null)
            {
                aufruf2("Detlef");
            }

            aufruf2?.Invoke("Detlef");

            Console.WriteLine();

            //Multicasting
            ErsterDelegat aufruf3;
            aufruf3 = Ansage;
            aufruf3 += Aussage;
            aufruf3 += Verabschiedung;
            aufruf3 = aufruf3 + Verabschiedung;
            aufruf3 -= Verabschiedung;

            aufruf3?.Invoke("Dörte");

            aufruf3 = null;
        }
        static void Ansage(string str)
        {
            Console.WriteLine($"Guten Tag, {str}!");
        }
        static void Aussage(string st)
        {
            Console.WriteLine($"{st} ist angekommen.");
        }
        static void Verabschiedung(string supderDuperString)
        {
            Console.WriteLine($"Vielen Dank für Ihren Besuch, {supderDuperString}.");
        }
    }
}
