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
  public  class CreateMovimientoHandler:IRequestHandler<CreateMovimientoCommand, MovimientoResponse>
    {
        private readonly IRepository<Movimiento> _movimientoRepo;
        public CreateMovimientoHandler(IRepository<Movimiento> repo)
        {
            _movimientoRepo = repo;
        }
        public async Task<MovimientoResponse> Handle(CreateMovimientoCommand request, CancellationToken cancelationToken)
        {
            var movimientoEntity = MovimientoMapper.Mapper.Map<Movimiento>(request);
            if (movimientoEntity is null)
            {
                throw new ApplicationException("Issue on mapper");
            }
            var newMovimiento = await _movimientoRepo.AddAsync(movimientoEntity);
            var movimientoResponse = MovimientoMapper.Mapper.Map<MovimientoResponse>(newMovimiento);
            return movimientoResponse;
        }
    }
}
