using System;
using System.Collections.Generic;

#nullable disable

namespace Infinitum.Data
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public string Profesion { get; set; }
        public string EstadoCivil { get; set; }
        public decimal? IngresosMensuales { get; set; }
        public int IdVehiculo { get; set; }
    }
}
