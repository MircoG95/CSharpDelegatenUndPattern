using System;

namespace Delegaten_AnonymeMethoden
{
    public delegate int Rechnen(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Rechnen r1 = delegate (int z1, int z2)
            {
                return z1 + z2;
            };

            int zahl = r1(5, 7);
            Console.WriteLine(zahl);

            zahl = r1(12, 18);
            Console.WriteLine(zahl);

            r1 = null;
        }
        private static int Addieren(int a, int b)
        {
            return a + b;
        }
    }
}
