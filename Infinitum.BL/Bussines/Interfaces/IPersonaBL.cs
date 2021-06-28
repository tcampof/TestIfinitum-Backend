//-----------------------------------------------------------------------
// <copyright file="IPersonaBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>25/06/2021 23:27:57</date>
// <summary>Código fuente clase IPersonaBL.</summary>
//-----------------------------------------------------------------------
using Infinitum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Domain
{
    /// <summary>
    /// IPersonaBL interface.
    /// </summary>
    public interface IPersonaBL
    {
        int CreatePersonaBL(PersonaDto persona);
        IList<PersonaDto> GetPersonas();
        int UpdatePersona(PersonaDto persona);
        int DeletePersona(int id);
        IList<HistorialDto> GetHistorial(int id);

    }
}