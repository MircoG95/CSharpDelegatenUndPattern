using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Bridge
{
    abstract class Design
    {
        public string Hersteller { get; set; }
        public abstract void AusgabeDesign();
    }
}
