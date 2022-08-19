using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Infrastructure.Data
{
   public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options){ }
        public DbSet<Ejercicio.Core.Entidades.Cliente> Clientes { get; set; }
        public DbSet<Ejercicio.Core.Entidades.Cuenta> Cuentas { get; set; }
        public DbSet<Ejercicio.Core.Entidades.Movimiento> Movimientos { get; set; }
    }
}
