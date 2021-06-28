using System;
using System.Collections.Generic;

#nullable disable

namespace Infinitum.Data
{
    public partial class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int? NumeroPuertas { get; set; }
        public string TipoVehiculo { get; set; }
    }
}
