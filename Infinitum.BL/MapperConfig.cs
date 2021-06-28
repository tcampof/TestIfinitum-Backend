//-----------------------------------------------------------------------
// <copyright file="MapperConfig.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Tomás Campo</author>
// <date>27/06/2021 9:18:38</date>
// <summary>Código fuente clase MapperConfig.</summary>
//-----------------------------------------------------------------------
using AutoMapper;
using Infinitum.Data;
using Infinitum.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinitum.Domain
{
    /// <summary>
    /// MapperConfig class.
    /// </summary>
    public class MapperConfig
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapperConfig"/> class.
        /// </summary>
        public MapperConfig()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Persona, PersonaDto>();
            });
           // IMapper = config.CreateMapper();
        }

        #endregion

        #region Properties

       // public static IMapper IMapper { get; set; }

        #endregion

        #region Methods And Functions

        public static IMapper IMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Persona, PersonaDto>();
                cfg.CreateMap<Vehiculo, VehiculoDto>();
            });
            return config.CreateMapper();
        }

        #endregion
    }
}