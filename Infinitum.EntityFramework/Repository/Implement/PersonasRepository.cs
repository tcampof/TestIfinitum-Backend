//-----------------------------------------------------------------------
// <copyright file="PersonasRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 22:42:12</date>
// <summary>Código fuente clase PersonasRepository.</summary>
//-----------------------------------------------------------------------
using Infinitum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using Dapper;
using System.Security.Claims;

namespace Infinitum.Data
{
    /// <summary>
    /// PersonasRepository class.
    /// </summary>
    public class PersonasRepository : IPersonasRepository
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonasRepository"/> class.
        /// </summary>
        public PersonasRepository()
        {
        }

        #endregion

        #region Properties

        public int CreatePersona(Persona persona)
        {
            using (TestDbContext dBContext = new TestDbContext())
            {
                int resp = 0;
                var transaction = dBContext.Database.BeginTransaction();
                try
                {

                    dBContext.Personas.Add(persona);
                    resp = dBContext.SaveChanges();
                    if (persona.IdVehiculo != 0)
                    {
                        var _personaVehiculo = new PersonasVehiculo()
                        {
                            IdPersona = persona.Id,
                            IdVehiculo = persona.IdVehiculo,
                            FechaCreacion = DateTime.Now
                        };
                        dBContext.PersonasVehiculos.Add(_personaVehiculo);
                        dBContext.SaveChanges();
                    }
                    transaction.Commit();
                    return resp;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public int DeletePersona(int id)
        {
            try
            {
                ConexionDB _conn = new ConexionDB();
                using (IDbConnection conn = _conn.GetConnection())
                {
                    conn.Open();
                    try
                    {
                        DynamicParameters objParams = new DynamicParameters();
                        objParams.Add("@id", id);

                        return conn.Execute("dbo.EliminarPersona",
                                  objParams,
                                  commandType: CommandType.StoredProcedure);
                    }
                    catch
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<HistorialDto> GetHistorial(int id)
        {
            ConexionDB _conn = new ConexionDB();
            using (IDbConnection conn = _conn.GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@Id", id);
                 

                    var data = conn.Query<HistorialDto>("dbo.ConsultarHistorial",
                            objParams,
                            commandType: CommandType.StoredProcedure).ToList();

                    return data;
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public Persona GetPersonaId(int id)
        {
            var persona = new Persona();
            return persona;
        }

        public IList<PersonaDto> GetPersonas()
        {
            using (TestDbContext dBContext = new TestDbContext())
            {
                var _personas = (from p in dBContext.Personas
                                 join v in dBContext.Vehiculos on p.IdVehiculo equals v.Id into pv
                                 from pvl in pv.DefaultIfEmpty()
                                 select new PersonaDto
                                 {
                                     Id = p.Id,
                                     Nombres = p.Nombres,
                                     Apellidos = p.Apellidos,
                                     EstadoCivil = p.EstadoCivil,
                                     FechaNacimiento = p.FechaNacimiento,
                                     Identificacion = p.Identificacion,
                                     IngresosMensuales = p.IngresosMensuales,
                                     Profesion = p.Profesion,
                                     PLacaVehiculo = pvl.Placa
                                 }).ToList();
                dBContext.SaveChanges();
                return _personas;
            }
        }

        public int UpdatePersona(PersonaDto persona)
        {
            ConexionDB _conn = new ConexionDB();
            using (IDbConnection conn = _conn.GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@Id", persona.Id);
                    objParams.Add("@Nombres", persona.Nombres);
                    objParams.Add("@Apellidos", persona.Apellidos);
                    objParams.Add("@FechaNacimiento", persona.FechaNacimiento);
                    objParams.Add("@Identificacion", persona.Identificacion);
                    objParams.Add("@Profesion", persona.Profesion);
                    objParams.Add("@EstadoCivil", persona.EstadoCivil);
                    objParams.Add("@IngresosMensuales", persona.IngresosMensuales);
                    objParams.Add("@IdVehiculo", persona.IdVehiculo);

                    var data = conn.ExecuteScalar<int>("dbo.EditarPersona",
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

        #region Methods And Functions

        #endregion
    }
}