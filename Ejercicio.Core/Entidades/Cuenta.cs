using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Core.Entidades
{
   public class Cuenta
    {
		[ForeignKey("PersonaID")]
		public int PersonaID { get; set; }
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int numeroCuenta { get; set; }
		public int tipoCuenta { get; set; }
		public int saldoInicial { get; set; }
		public string estado { get; set; }
		public virtual Cliente ClienteId { get; set; }
	}
}
