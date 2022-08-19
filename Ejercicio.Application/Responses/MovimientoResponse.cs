using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Responses
{
  public class MovimientoResponse
    {
		public int PersonaID { get; set; }
		public int numeroCuenta { get; set; }
		public DateTime fecha { get; set; }
		public string tipoMovimiento { get; set; }
		public int valor { get; set; }
		public int saldo { get; set; }
		public bool estado { get; set; } 
	}
}
