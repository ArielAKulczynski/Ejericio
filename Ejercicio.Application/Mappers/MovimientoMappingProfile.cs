using AutoMapper;
using Ejercicio.Application.Commands;
using Ejercicio.Application.Responses;
using Ejercicio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Mappers
{
   public class MovimientoMappingProfile:Profile
    {
        public MovimientoMappingProfile()
        {
            CreateMap<Movimiento, MovimientoResponse>().ReverseMap();
            CreateMap<Movimiento, CreateMovimientoCommand>().ReverseMap();
        }
    }
}
