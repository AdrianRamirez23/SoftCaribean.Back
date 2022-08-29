using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Test.Models
{
    public partial class DataMaestra
    {
        public string Nmmaestro { get; set; }
        public string Nmdato { get; set; }
        public string Cddato { get; set; }
        public string Cadato1 { get; set; }
        public string Cddato2 { get; set; }
        public string Cddato3 { get; set; }
        public byte[] Feregistro { get; set; }
        public DateTime Febaja { get; set; }

        public virtual Maestra NmmaestroNavigation { get; set; }
    }
}
