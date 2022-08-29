using Data.Test.Models;
using Services.Test;
using System;
using System.Collections.Generic;

namespace Bussines.Test
{
    public class PersonaBS: IPersonaBS
    {
        private readonly PersonaSv _personaSv;
        public PersonaBS(PersonaSv personaSv)
        {
            _personaSv = personaSv;
        }
        public List<Persona> GetPersonas()
        {
          return  _personaSv.GetPersonas();
        }
        public string CreatePersonas(Persona persona)
        {
            return _personaSv.CreatePersona(persona);
        }
        public string UpdatePersonas(Persona persona)
        {
            return _personaSv.UpdatePersona(persona);
        }
    }
}
