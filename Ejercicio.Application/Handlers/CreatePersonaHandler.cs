using Ejercicio.Application.Commands;
using Ejercicio.Application.Mappers;
using Ejercicio.Application.Responses;
using Ejercicio.Core.Entidades;
using Ejercicio.Core.Repositorios.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio.Application.Handlers
{
    public class CreatePersonaHandler:IRequestHandler<CreatePersonaCommand, PersonaResponse>
    {
        private readonly IRepository<Persona> _personaRepo;
        public CreatePersonaHandler(IRepository<Persona> repo)
        {
            _personaRepo = repo;
        }
        public async Task<PersonaResponse> Handle(CreatePersonaCommand request, CancellationToken cancelationToken)
        {
            var personaEntity = PersonaMapper.Mapper.Map<Persona>(request);
            if (personaEntity is null)
            {
                throw new ApplicationException("Issue on mapper");
            }
            var newPersona = await _personaRepo.AddAsync(personaEntity);
            var personaResponse = PersonaMapper.Mapper.Map<PersonaResponse>(newPersona);
            return personaResponse;
        }
    }
}
