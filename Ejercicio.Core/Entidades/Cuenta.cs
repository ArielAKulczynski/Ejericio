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
		
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int numeroCuenta { get; set; }
		[ForeignKey("Cliente")]
		public int ClienteId { get; set; }
		public virtual Cliente Cliente { get; set; }
		public string tipoCuenta { get; set; }
		public int saldoInicial { get; set; }
		public bool estado { get; set; }
		
	}
}
