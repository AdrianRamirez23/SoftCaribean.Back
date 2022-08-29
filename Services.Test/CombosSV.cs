using Data.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test
{
    public class CombosSV
    {
        private readonly ContextMain _context;
        public CombosSV(ContextMain context)
        {
            _context = context;
        }

        public List<DataMaestra> ListTipoPersona()
        {
            var result = (from data in _context.DataMaestras where data.Nmmaestro == "02" orderby data.Nmdato descending select data).ToList();
            return result;
        }
        public List<DataMaestra> ListTipoGenero()
        {
            var result = (from data in _context.DataMaestras where data.Nmmaestro == "03" orderby data.Nmdato descending select data).ToList();
            return result;
        }
        public List<DataMaestra> ListTipoDocumento()
        {
            var result = (from data in _context.DataMaestras where data.Nmmaestro == "01" orderby data.Nmdato descending select data).ToList();
            return result;
        }
        public List<DataMaestra> ListTipoUsuario()
        {
            var result = (from data in _context.DataMaestras where data.Nmmaestro == "04" orderby data.Nmdato descending select data).ToList();
            return result;
        }
    }
}
