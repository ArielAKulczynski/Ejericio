using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Core.Entidades
{
    public class Movimiento
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MovimientoId { get; set; }
		[ForeignKey("PersonaID")]
		public int PersonaID { get; set; }
		[ForeignKey("numeroCuenta")]
		public int numeroCuenta { get; set; }
		public DateTime fecha { get; set; }
		public string tipoMovimiento { get; set; }
		public int valor { get; set; }
		public int saldo { get; set; }
		public virtual Cliente PersonaCliente { get; set; }
		public virtual Cuenta CuentaNumero { get; set; }
	}
}
