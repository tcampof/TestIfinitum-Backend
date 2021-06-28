//-----------------------------------------------------------------------
// <copyright file="VehiculoRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 22:50:10</date>
// <summary>Código fuente clase VehiculoRepository.</summary>
//-----------------------------------------------------------------------
using Dapper;
using Infinitum.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Infinitum.Data
{
    /// <summary>
    /// VehiculoRepository class.
    /// </summary>
    public class VehiculoRepository : IVehiculoRepository
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VehiculoRepository"/> class.
        /// </summary>
        public VehiculoRepository()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods And Functions
        public int CreateVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (TestDbContext dBContext = new TestDbContext())
                {
                    dBContext.Vehiculos.Add(vehiculo);
                    return dBContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
                throw;
            }

        }

        public int CreateVehiculoPersona(PersonasVehiculo vehiculo)
        {
            try
            {
                using (TestDbContext dBContext = new TestDbContext())
                {
                    dBContext.PersonasVehiculos.Add(vehiculo);
                    return dBContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
                throw;
            }

        }

        public Vehiculo DeleteVehiculo(int id)
        {
            throw new NotImplementedException();
        }

        public Vehiculo GetVehiculoId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<VehiculoDto> GetVehiculos()
        {
            try
            {
                using (TestDbContext dBContext = new TestDbContext())
                {
                    var _vehiculo = (from v in dBContext.Vehiculos
                                     select new VehiculoDto
                                     {
                                         Id = v.Id,
                                         Marca = v.Marca,
                                         Modelo = v.Modelo,
                                         NumeroPuertas = v.NumeroPuertas,
                                         Placa = v.Placa,
                                         TipoVehiculo = v.TipoVehiculo
                                     }).ToList();
                    dBContext.SaveChanges();
                    return _vehiculo;
                }

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public int UpdateVehiculo(VehiculoDto vehiculo)
        {
            ConexionDB _conn = new ConexionDB();
            using (IDbConnection conn = _conn.GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@Id", vehiculo.Id);
                    objParams.Add("@Placa", vehiculo.Placa);
                    objParams.Add("@Marca", vehiculo.Marca);
                    objParams.Add("@Modelo", vehiculo.Modelo);
                    objParams.Add("@NumeroPuertas", vehiculo.NumeroPuertas);
                    objParams.Add("@TipoVehiculo", vehiculo.TipoVehiculo);

                    var data = conn.ExecuteScalar<int>("dbo.EditarVehiculo",
                            objParams,
                            commandType: CommandType.StoredProcedure);

                    return data;
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        #endregion
    }
}