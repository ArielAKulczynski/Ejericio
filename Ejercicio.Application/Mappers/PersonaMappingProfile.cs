using Ejercicio.Application.Responses;
using Ejercicio.Core.Entidades;
using Ejercicio.Application.Commands;
using AutoMapper;

namespace Ejercicio.Application.Mappers
{
    public class PersonaMappingProfile:Profile
    {
        public PersonaMappingProfile()
        {
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<Persona, CreatePersonaCommand>().ReverseMap();
        }
    }
}
