using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Core.Entidades
{
   public class Cliente: Persona
    {
        public string contraseña { get; set; }
        public bool estado { get; set; }
        public virtual ICollection <Cuenta> clienteCuenta { get; set; }
    }
}
