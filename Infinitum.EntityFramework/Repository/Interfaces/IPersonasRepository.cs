//-----------------------------------------------------------------------
// <copyright file="IPersonasRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 22:42:40</date>
// <summary>Código fuente clase IPersonasRepository.</summary>
//-----------------------------------------------------------------------
using Infinitum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Data
{
    /// <summary>
    /// IPersonasRepository interface.
    /// </summary>
    public interface IPersonasRepository
    {
        /// <summary>
        /// Metodo utilizado para crear personas en la base de datos
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        int CreatePersona(Persona persona);

        /// <summary>
        /// Metodo utilizado para actualizar una persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        int UpdatePersona(PersonaDto persona);

        /// <summary>
        /// Metodo utilizado para obtener una lista de todas las personas registradas
        /// </summary>
        /// <returns></returns>
        IList<PersonaDto> GetPersonas();

        /// <summary>
        /// Metodo utilizado para obtener una persona por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Persona GetPersonaId(int id);

        /// <summary>
        /// Metodo utiliado para eliminar una persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeletePersona(int id);

        /// <summary>
        /// Metodo para consultar el historial de vehiculos
        /// </summary>
        /// <returns></returns>
        IList<HistorialDto> GetHistorial(int id);

        
    }
}