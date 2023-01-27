using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Pattern_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BuecherListe b1 = new BuecherListe();
            b1 = BuecherListe.DatenEinlesen(b1);

            Console.WriteLine(b1.books[1].title);

            //XmlAdapter adapter = new XmlAdapter(b1);
            IBuecherAdapter adapter = new XmlAdapter(b1);
            adapter = new SqlAdapter(b1);
        }
    }
}
