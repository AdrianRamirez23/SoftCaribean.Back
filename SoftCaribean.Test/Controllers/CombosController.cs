using Bussines.Test;
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
    public class CombosController : ControllerBase
    {
        private readonly ICombosBS _combos;
        public CombosController(ICombosBS combosBS)
        {
            _combos = combosBS;
        }
        [HttpGet]
        [Route("ListTipoPersona")]
        public IActionResult ListTipoPersona()
        {
            var result = _combos.ListTipoPersona();

            return Ok(new
            {
                Estado = true,
                Mensaje = "Lista correcta",
                Result = result
            });
        }
        [HttpGet]
        [Route("ListTipoGenero")]
        public IActionResult ListTipoGenero()
        {
            var result = _combos.ListTipoGenero();

            return Ok(new
            {
                Estado = true,
                Mensaje = "Lista correcta",
                Result = result
            });
        }
        [HttpGet]
        [Route("ListTipoDocumento")]
        public IActionResult ListTipoDocumento()
        {
            var result = _combos.ListTipoDocumento();

            return Ok(new
            {
                Estado = true,
                Mensaje = "Lista correcta",
                Result = result
            });
        }
        [HttpGet]
        [Route("ListTipoUsuario")]
        public IActionResult ListTipoUsuario()
        {
            var result = _combos.ListTipoUsuario();

            return Ok(new
            {
                Estado = true,
                Mensaje = "Lista correcta",
                Result = result
            });
        }
    }
}
