//-----------------------------------------------------------------------
// <copyright file="IVehiculoRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 22:48:23</date>
// <summary>Código fuente clase IVehiculoRepository.</summary>
//-----------------------------------------------------------------------

using Infinitum.Models;
using System.Collections.Generic;

namespace Infinitum.Data
{
    /// <summary>
    /// IVehiculoRepository interface.
    /// </summary>
    public interface IVehiculoRepository
    {
        /// <summary>
        /// Metodo utilizado para crear vehiculos en la base de datos
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        int CreateVehiculo(Vehiculo vehiculo);

        /// <summary>
        /// Metodo utilizado para actualizar una vehiculo
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        int UpdateVehiculo(VehiculoDto vehiculo);

        /// <summary>
        /// Metodo utilizado para obtener una lista de todas las vehiculos registradas
        /// </summary>
        /// <returns></returns>
        IList<VehiculoDto> GetVehiculos();

        /// <summary>
        /// Metodo utilizado para obtener una vehiculo por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Vehiculo GetVehiculoId(int id);

        /// <summary>
        /// Metodo utiliado para eliminar una vehiculo de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Vehiculo DeleteVehiculo(int id);
    }
}