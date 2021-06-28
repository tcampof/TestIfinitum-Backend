using System;
using System.Collections.Generic;

#nullable disable

namespace Infinitum.Data
{
    public partial class PersonasVehiculo
    {
        public int Id { get; set; }
        public int IdVehiculo { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual Vehiculo IdVehiculoNavigation { get; set; }
    }
}
