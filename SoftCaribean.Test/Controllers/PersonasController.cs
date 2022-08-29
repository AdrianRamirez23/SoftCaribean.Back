using Bussines.Test;
using Data.Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftCaribean.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaBS _persona;

        public PersonasController(IPersonaBS persona)
        {
            _persona = persona;
        }

        [HttpGet]
        [Route("GetPersonas")]
        public IActionResult GetPersonas()
        {
            var result = _persona.GetPersonas();

            return Ok(new
            {
                Estado = true,
                Mensaje = "Personas Listadas",
                Result = result
            });
        }
        [HttpPost]
        [Route("CreatePersonas")]
        public IActionResult CreatePersonas(Persona persona)
        {
            persona.Febaja = DateTime.Now;
            persona.Feregistro = DateTime.Now;
            persona.Cdusuario = "automatico";
            var result = _persona.CreatePersonas(persona);

            return Ok(new
            {
                Estado = true,
                Mensaje = "Personas Creadas",
                Result = result
            });
        }
        [HttpPut]
        [Route("UpdatePersonas")]
        public IActionResult UpdatePersonas(Persona persona)
        {
            var result = _persona.UpdatePersonas(persona);

            return Ok(new
            {
                Estado = true,
                Mensaje = "Personas Creadas",
                Result = result
            });
        }
    }
}
