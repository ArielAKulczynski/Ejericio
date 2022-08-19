using AutoMapper;
using Ejercicio.Application.Commands;
using Ejercicio.Application.Commands.Delete;
using Ejercicio.Application.Responses;
using Ejercicio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Mappers
{
   public class ClienteMappingProfile:Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
            CreateMap<Cliente, CreateClienteCommand>().ReverseMap();
        }
    }
}
