//-----------------------------------------------------------------------
// <copyright file="PersonaDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 22:38:50</date>
// <summary>Código fuente clase PersonaDto.</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Models
{
    /// <summary>
    /// PersonaDto class.
    /// </summary>
    public class PersonaDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaDto"/> class.
        /// </summary>
        public PersonaDto()
        {
        }

        #endregion

        #region Properties
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public string Profesion { get; set; }
        public string EstadoCivil { get; set; }
        public decimal? IngresosMensuales { get; set; }
        public int IdVehiculo { get; set; }
        public string PLacaVehiculo { get; set; }

        #endregion

        #region Methods And Functions

        #endregion
    }
}