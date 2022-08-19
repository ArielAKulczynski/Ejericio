using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Commands.Delete
{
   public class DeleteClientCommand: IRequest<int>
    {
        public int Id { get; set; }
    }
}
