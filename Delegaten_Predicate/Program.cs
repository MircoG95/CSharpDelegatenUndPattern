using System;

namespace Delegaten_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate: immer Rückgabewert bool, genau ein Parameter
            Predicate<int> p1 = Entscheidung;
            Console.WriteLine(p1(15));

            Func<int, bool> f1 = Entscheidung;
            Console.WriteLine(f1(15));

        }
        static bool Entscheidung(int a)
        {
            if (a > 10)
                return true;
            else
                return false;
        }
    }
}
