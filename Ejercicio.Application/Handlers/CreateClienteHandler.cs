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
   public class CreateClienteHandler:IRequestHandler<CreateClienteCommand, ClienteResponse>
    {
        private readonly IRepository<Cliente> _personaRepo;
        public CreateClienteHandler (IRepository<Cliente> repo)
        {
            _personaRepo = repo;
        }
        public async Task<ClienteResponse> Handle(CreateClienteCommand request, CancellationToken cancelationToken)
        {
            var personaEntity = ClienteMapper.Mapper.Map<Cliente>(request);
            if (personaEntity is null)
            {
                throw new ApplicationException("Issue on mapper");
            }
            var newPersona = await _personaRepo.AddAsync(personaEntity);
            var personaResponse = ClienteMapper.Mapper.Map<ClienteResponse>(newPersona);
            return personaResponse;
        }
    }
}
