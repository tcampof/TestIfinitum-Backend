//-----------------------------------------------------------------------
// <copyright file="iVehiculoBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 23:27:30</date>
// <summary>Código fuente clase iVehiculoBL.</summary>
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
    /// iVehiculoBL interface.
    /// </summary>
    public interface IVehiculoBL
    {
        int CreateVehiculoBL(VehiculoDto vehiculo);
        IList<VehiculoDto> GetVehiculos();
        int UpdateVehiculo(VehiculoDto vehiculo);
    }
}