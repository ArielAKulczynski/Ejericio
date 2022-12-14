// <auto-generated />
using System;
using Ejercicio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ejercicio.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ejercicio.Core.Entidades.Cliente", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Identificacion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("PersonaID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Ejercicio.Core.Entidades.Cuenta", b =>
                {
                    b.Property<int>("numeroCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<int>("saldoInicial")
                        .HasColumnType("int");

                    b.Property<string>("tipoCuenta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("numeroCuenta");

                    b.HasIndex("ClienteId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Ejercicio.Core.Entidades.Movimiento", b =>
                {
                    b.Property<int>("MovimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CuentaNumeronumeroCuenta")
                        .HasColumnType("int");

                    b.Property<int?>("PersonaClientePersonaID")
                        .HasColumnType("int");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("numeroCuenta")
                        .HasColumnType("int");

                    b.Property<int>("saldo")
                        .HasColumnType("int");

                    b.Property<string>("tipoMovimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("MovimientoId");

                    b.HasIndex("CuentaNumeronumeroCuenta");

                    b.HasIndex("PersonaClientePersonaID");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("Ejercicio.Core.Entidades.Cuenta", b =>
                {
                    b.HasOne("Ejercicio.Core.Entidades.Cliente", "Cliente")
                        .WithMany("clienteCuenta")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Ejercicio.Core.Entidades.Movimiento", b =>
                {
                    b.HasOne("Ejercicio.Core.Entidades.Cuenta", "CuentaNumero")
                        .WithMany()
                        .HasForeignKey("CuentaNumeronumeroCuenta");

                    b.HasOne("Ejercicio.Core.Entidades.Cliente", "PersonaCliente")
                        .WithMany()
                        .HasForeignKey("PersonaClientePersonaID");

                    b.Navigation("CuentaNumero");

                    b.Navigation("PersonaCliente");
                });

            modelBuilder.Entity("Ejercicio.Core.Entidades.Cliente", b =>
                {
                    b.Navigation("clienteCuenta");
                });
#pragma warning restore 612, 618
        }
    }
}
