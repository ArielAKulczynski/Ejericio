using Ejercicio.Application.Commands.Delete;
using Ejercicio.Core.Entidades;
using Ejercicio.Core.Repositorios.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio.Application.Handlers.Delete
{
    public class DeleteCuentaHandler:IRequestHandler<DeleteCuentaCommand, int>
    {
        private readonly IRepository<Cuenta> _cuentaRepo;

        public DeleteCuentaHandler(IRepository<Cuenta> repo)
        {
            _cuentaRepo = repo;
        }
        public async Task<int> Handle(DeleteCuentaCommand request, CancellationToken cancelationToken)
        {
            await _cuentaRepo.DeleteAsync(_cuentaRepo.GetByIdAsync(request.Id).Result);
            return request.Id;
        }
    }
}

