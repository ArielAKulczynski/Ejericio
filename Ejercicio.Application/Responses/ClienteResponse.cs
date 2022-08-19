using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Responses
{
    public class ClienteResponse
    {
		public string nombre { get; set; }
		public string genero { get; set; }
		public int edad { get; set; }
		public int identificación { get; set; }
		public string dirección { get; set; }
		public int teléfono { get; set; }
	}
}
