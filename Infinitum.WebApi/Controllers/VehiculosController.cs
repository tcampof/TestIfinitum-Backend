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
    public class VehiculosController : Controller
    {
        public IVehiculoBL VehiculoBL { get; set; }
        public VehiculosController(IVehiculoBL vehiculo) : base()
        {
            this.VehiculoBL = vehiculo;
        }

        [HttpPost("vehiculo")]
        public IActionResult GuardarVehiculo(VehiculoDto vehiculo)
        {
            int result = this.VehiculoBL.CreateVehiculoBL(vehiculo);
            return this.Ok(result);
        }

        [HttpGet("vehiculos")]
        public ActionResult ObtenerVehiculo()
        {
            IList<VehiculoDto> result = this.VehiculoBL.GetVehiculos();
            return this.Ok(result);
        }

        [HttpPost("vehiculoEditar")]
        public IActionResult EditarVehiculo(VehiculoDto vehiculo)
        {
            int result = this.VehiculoBL.UpdateVehiculo(vehiculo);
            return this.Ok(result);
        }
    }
}
