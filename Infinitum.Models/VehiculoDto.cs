//-----------------------------------------------------------------------
// <copyright file="Vehiculo.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 22:39:31</date>
// <summary>Código fuente clase Vehiculo.</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Models
{
    /// <summary>
    /// Vehiculo class.
    /// </summary>
    public class VehiculoDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VehiculoDto"/> class.
        /// </summary>
        public VehiculoDto()
        {
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int? NumeroPuertas { get; set; }
        public string TipoVehiculo { get; set; }

        #endregion

        #region Methods And Functions

        #endregion
    }
}