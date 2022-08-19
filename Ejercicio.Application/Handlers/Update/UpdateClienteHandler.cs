using Ejercicio.Application.Commands.Updates;
using Ejercicio.Core.Entidades;
using Ejercicio.Core.Repositorios.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio.Application.Handlers.Update
{
   public class UpdateClienteHandler : IRequestHandler<UpdateClientCommand, int>
    {
        private readonly IRepository<Cliente> _clientRepo;

        public UpdateClienteHandler(IRepository<Cliente> repo)
        {
            _clientRepo = repo;
        }
        public async Task<int> Handle(UpdateClientCommand request, CancellationToken cancelationToken)
        {
            var cliente = _clientRepo.GetByIdAsync(request.Id).Result;
            cliente.contraseña = request.contraseña;
            cliente.estado = request.estado;
            cliente.Nombre = request.nombre;
            cliente.Genero = request.genero;
            cliente.Edad = request.edad;
            cliente.Identificacion = request.identificacion;
            cliente.Direccion = request.direccion;
            cliente.Telefono = request.telefono;
            await _clientRepo.UpdateAsync(_clientRepo.GetByIdAsync(request.Id).Result);
            return request.Id;
        }
    }
}
