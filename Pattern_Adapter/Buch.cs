using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
    [DataContract]
    public class Buch
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string language { get; set; }
        [DataMember]
        public string edition { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string author { get; set; }
    }
}
