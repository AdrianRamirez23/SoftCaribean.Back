using Data.Test.Models;
using Services.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Test
{
    public class CombosBS: ICombosBS
    {
        private readonly CombosSV _combo;
        public CombosBS(CombosSV combos)
        {
            _combo = combos;
        }
        public List<DataMaestra> ListTipoPersona()
        {
            return _combo.ListTipoPersona();
        }
        public List<DataMaestra> ListTipoGenero()
        {
            return _combo.ListTipoGenero();
        }
        public List<DataMaestra> ListTipoDocumento()
        {
            return _combo.ListTipoDocumento();
        }
        public List<DataMaestra> ListTipoUsuario()
        {
            return _combo.ListTipoUsuario();
        }
    }
}
