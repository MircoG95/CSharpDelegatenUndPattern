using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
    [DataContract]
    public class BuecherListe
    {
        //Felder
        [DataMember]
        public List<Buch> books;

        //Methoden
        public static BuecherListe DatenEinlesen(BuecherListe b)
        {
            string pfad = @"C:\Test\Buecher.json";

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BuecherListe));

            using (FileStream fs = new FileStream(pfad, FileMode.Open))
            {
                b = (BuecherListe)ser.ReadObject(fs);
            }

            return b;
        }
    }
}
