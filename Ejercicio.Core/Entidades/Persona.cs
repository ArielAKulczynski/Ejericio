using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Core.Entidades
{
	public class Persona
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PersonaID { get;set; }
		public string Nombre { get; set; }
		public string Genero { get; set; }
		public int Edad { get; set; }
		public int Identificacion { get; set; }
		public string Direccion { get; set; }
		public int Telefono { get; set; }
	}
}
