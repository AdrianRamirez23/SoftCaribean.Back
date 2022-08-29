using Data.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Test
{
    public interface IPersonaBS
    {
        List<Persona> GetPersonas();
        string CreatePersonas(Persona persona);
        string UpdatePersonas(Persona persona);
    }
}
