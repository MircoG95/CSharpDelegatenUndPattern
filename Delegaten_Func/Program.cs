using System;

namespace Delegaten_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func: einen Rückgabewert und von 0 bis 16 Parameter
            //Minimum: Rückgabewert ohne Parameter
            Func<int, int, int> f = Subtrahieren;

            Console.WriteLine(f(2,3));
            Console.WriteLine(f.Invoke(10, 5));

            Func<int> f2 = Zufall;

            Console.WriteLine(f2());

        }
        static int Zufall()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }
        static int Subtrahieren(int a, int b)
        {
            return a - b;
        }
    }
}
