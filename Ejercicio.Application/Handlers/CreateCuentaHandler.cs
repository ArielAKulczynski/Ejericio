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
    public class CreateCuentaHandler : IRequestHandler<CreateCuentaCommand, CuentaResponse>
    {
        private readonly IRepository<Cuenta> _cuentaRepo;
        public CreateCuentaHandler(IRepository<Cuenta> repo)
        {
            _cuentaRepo = repo;
        }
        public async Task<CuentaResponse> Handle(CreateCuentaCommand request, CancellationToken cancelationToken)
        {
            var cuentaEntity = CuentaMapper.Mapper.Map<Cuenta>(request);
            if (cuentaEntity is null)
            {
                throw new ApplicationException("Issue on mapper");
            }
            var newCuenta = await _cuentaRepo.AddAsync(cuentaEntity);
            var personaResponse = PersonaMapper.Mapper.Map<CuentaResponse>(newCuenta);
            return personaResponse;
        }
    }
}
