using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Singleton         //Creational Pattern
{
    //Diese Klasse darf nur einmal instanziiert werden
    //Sollte diese Klasse ein 2. mal instanziiert werden, soll keine neue Instanz gebildet werden, sondern
    //nur die bereits bestehende Instanz übergeben werden
    class Regierung
    {
        //Felder
        public string name;

        //statische Felder
        private static Regierung instance;

        //Konstruktor
        private Regierung() { }

        //statische Methoden
        public static Regierung GetInstance()
        {
            if (instance == null)
            {
                instance = new Regierung();
            }
            return instance;
        }
    }
}
