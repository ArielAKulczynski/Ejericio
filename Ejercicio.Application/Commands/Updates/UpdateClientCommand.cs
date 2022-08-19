using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Commands.Updates
{
   public class UpdateClientCommand : IRequest<int>
    {

		public int Id { get; set; }
		public string direccion { get; set; }
		public int edad { get; set; }
		public string genero { get; set; }
		public int identificacion { get; set; }
		public string nombre { get; set; }
		public int telefono { get; set; }
		public string contraseña { get; set; }
		public bool estado { get; set; }
	}
}