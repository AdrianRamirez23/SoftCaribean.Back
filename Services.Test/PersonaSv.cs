using Data.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Test
{
    public class PersonaSv
    {
        private readonly ContextMain contextMain;
        public PersonaSv(ContextMain _contextMain)
        {
            contextMain = _contextMain;
        }
        public List<Persona> GetPersonas()
        {
            var result = contextMain.Personas.ToList();
            return result;
        }
        public string CreatePersona(Persona persona)
        {
            try
            {
                contextMain.Personas.Add(persona);
                contextMain.SaveChanges();

                return "Persona Creada con éxito";
            }
            catch (Exception ex)
            {

                return "Error al crear una persona";
            }
           
        }
        public string UpdatePersona(Persona persona)
        {
            try
            {
                contextMain.Personas.Update(persona);
                contextMain.SaveChanges();

                return "Persona Actualizada con éxito";
            }
            catch (Exception)
            {

                return "Error al Actualizar una persona";
            }

        }
    }
}
