using Ejercicio.Application.Commands.Delete;
using Ejercicio.Application.Mappers;
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
    public class DeleteCommandHandler : IRequestHandler<DeleteClientCommand, int>
    {
        private readonly IRepository<Cliente> _clientRepo;
        
        public DeleteCommandHandler(IRepository<Cliente> repo)
        {
            _clientRepo = repo;
        }
        public async Task<int> Handle(DeleteClientCommand request, CancellationToken cancelationToken)
        {      
            await _clientRepo.DeleteAsync(_clientRepo.GetByIdAsync(request.Id).Result);
            return request.Id;
        }
    }
}
