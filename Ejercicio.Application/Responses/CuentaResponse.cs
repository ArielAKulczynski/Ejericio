using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Responses
{
   public class CuentaResponse
    {
		public int PersonaID { get; set; }
		public int numeroCuenta { get; set; }
		public int tipoCuenta { get; set; }
		public int saldoInicial { get; set; }
		public string estado { get; set; }
	}
}
