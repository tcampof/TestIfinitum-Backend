using Infinitum.Domain;
using Infinitum.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinitum.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    [Produces("application/json")]
    public class PersonasController : Controller
    {
        public IPersonaBL PersonaBL { get; set; }
        public PersonasController(IPersonaBL persona) : base()
        {
            this.PersonaBL = persona;
        }

        [HttpPost("persona")]
        public IActionResult GuardarPersona(PersonaDto persona)
        {
            int result = this.PersonaBL.CreatePersonaBL(persona);
            return this.Ok(result);
        }

        [HttpGet("personas")]
        public ActionResult ObtenerPersona()
        {
            IList<PersonaDto> result = this.PersonaBL.GetPersonas();
            return this.Ok(result);
        }

        [HttpPut("persona")]
        public IActionResult EliminarPersona(int id)
        {
            int result = this.PersonaBL.DeletePersona(id);
            return this.Ok(result);
        }

        [HttpPost("personaEdit")]
        public IActionResult ActualizarPersona(PersonaDto persona)
        {
            int result = this.PersonaBL.UpdatePersona(persona);
            return this.Ok(result);
        }

        [HttpGet("Historial")]
        public ActionResult ObtenerHistorial(int id)
        {
            IList<HistorialDto> result = this.PersonaBL.GetHistorial(id);
            return this.Ok(result);
        }
    }
}
