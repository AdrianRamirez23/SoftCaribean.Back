using Data.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Test
{
    public interface ICombosBS
    {
        List<DataMaestra> ListTipoPersona();
        List<DataMaestra> ListTipoGenero();
        List<DataMaestra> ListTipoDocumento();
        List<DataMaestra> ListTipoUsuario();
    }
}
