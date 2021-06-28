using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum.Models
{
    public class HistorialDto
    {
        public string NombreCompleto { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumeroPuertas { get; set; }
        public string TipoVehiculo { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
