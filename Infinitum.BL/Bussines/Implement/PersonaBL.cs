//-----------------------------------------------------------------------
// <copyright file="PersonaBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 23:36:37</date>
// <summary>Código fuente clase PersonaBL.</summary>
//-----------------------------------------------------------------------
using AutoMapper;
using Infinitum.Data;
using Infinitum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Domain
{
    /// <summary>
    /// PersonaBL class.
    /// </summary>
    public class PersonaBL : IPersonaBL
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaBL"/> class.
        /// </summary>
        public PersonaBL()
        {
            PersonasRepository = new PersonasRepository();
        }

        #endregion

        #region Properties

        public PersonasRepository PersonasRepository { get; set; }
        public static IMapper IMapper { get; set; }
        #endregion

        #region Methods And Functions
        public int CreatePersonaBL(PersonaDto persona)
        {

            try
            {
                Persona _persona = new Persona() { 
                    Nombres = persona.Nombres,
                    Apellidos = persona.Apellidos,
                    FechaNacimiento = persona.FechaNacimiento,
                    EstadoCivil = persona.EstadoCivil,
                    Identificacion = persona.Identificacion,
                    IngresosMensuales = persona.IngresosMensuales,
                    Profesion = persona.Profesion,
                    IdVehiculo = persona.IdVehiculo
                };
                return PersonasRepository.CreatePersona(_persona);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<PersonaDto> GetPersonas()
        {
            try
            {
                return PersonasRepository.GetPersonas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdatePersona(PersonaDto persona)
        {
            try
            {
                return PersonasRepository.UpdatePersona(persona);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeletePersona(int id)
        {
            try
            {
                return PersonasRepository.DeletePersona(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<HistorialDto> GetHistorial(int id)
        {
            try
            {
                return PersonasRepository.GetHistorial(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}