using System;

namespace Pattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Regierung p1 = Regierung.GetInstance();
            p1.name = "Kanzler Scholz";

            Regierung p2 = Regierung.GetInstance();
            p2.name = "Putsch-Kanzlerin Baerbock";

            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);
        }
    }
}
