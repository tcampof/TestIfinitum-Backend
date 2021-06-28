//-----------------------------------------------------------------------
// <copyright file="VehiculoBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 23:35:51</date>
// <summary>Código fuente clase VehiculoBL.</summary>
//-----------------------------------------------------------------------
using Infinitum.Data;
using Infinitum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Domain
{
    /// <summary>
    /// VehiculoBL class.
    /// </summary>
    public class VehiculoBL : IVehiculoBL
    {
        #region Attributes

        #endregion

        #region Constructors

        public VehiculoRepository VehiculoRepository { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VehiculoBL"/> class.
        /// </summary>
        public VehiculoBL()
        {
            this.VehiculoRepository = new VehiculoRepository();
        }

        #endregion

        #region Properties


        #endregion

        #region Methods And Functions

        public int CreateVehiculoBL(VehiculoDto vehiculo)
        {
            try
            {
                Vehiculo _vehiculo = new Vehiculo
                {
                    Marca = vehiculo.Marca,
                    Modelo = vehiculo.Modelo,
                    NumeroPuertas = vehiculo.NumeroPuertas,
                    Placa = vehiculo.Placa,
                    TipoVehiculo = vehiculo.TipoVehiculo
                };
                return VehiculoRepository.CreateVehiculo(_vehiculo);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IList<VehiculoDto> GetVehiculos()
        {
            try
            {
                return VehiculoRepository.GetVehiculos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateVehiculo(VehiculoDto vehiculo)
        {
            try
            {
                return VehiculoRepository.UpdateVehiculo(vehiculo);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}