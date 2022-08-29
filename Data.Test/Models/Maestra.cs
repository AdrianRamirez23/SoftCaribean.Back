using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Test.Models
{
    public partial class Maestra
    {
        public Maestra()
        {
            DataMaestras = new HashSet<DataMaestra>();
        }

        public string Nmmaestro { get; set; }
        public string Cdmaestro { get; set; }
        public string Dsmaestro { get; set; }
        public byte[] Feregistro { get; set; }
        public DateTime Febaja { get; set; }

        public virtual ICollection<DataMaestra> DataMaestras { get; set; }
    }
}
