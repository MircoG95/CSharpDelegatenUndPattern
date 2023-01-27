using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
    class SqlAdapter : IBuecherAdapter
    {
        //Felder
        public BuecherListe b;

        //Konstruktor
        public SqlAdapter(BuecherListe b)
        {
            this.b = b;
            DatenSchreiben();
        }

        public void DatenSchreiben()
        {
            throw new NotImplementedException();
        }
    }
}
