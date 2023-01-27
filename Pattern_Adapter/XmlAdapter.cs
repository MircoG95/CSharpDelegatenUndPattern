using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pattern_Adapter
{
    class XmlAdapter : IBuecherAdapter
    {
        //Felder
        public BuecherListe b;

        //Konstruktor
        public XmlAdapter(BuecherListe b)
        {
            this.b = b;
            DatenSchreiben();
        }

        //Methoden
        public void DatenSchreiben()
        {
            string pfad = @"C:\Test\Buecher.xml";

            XmlSerializer ser = new XmlSerializer(typeof(BuecherListe));

            using (FileStream fs = new FileStream(pfad, FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, b);
            }
        }
    }
}
