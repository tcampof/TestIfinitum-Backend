
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Infinitum.Data
{
    public partial class TestDbContext : DbContext
    {
        public string Connection { get; set; }
        public TestDbContext()
        {
            ConexionDB bd = new();
            Connection = bd.ConnectionString;
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonasVehiculo> PersonasVehiculos { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Apellidos).HasMaxLength(50);

                entity.Property(e => e.EstadoCivil).HasMaxLength(50);

                entity.Property(e => e.Identificacion).HasMaxLength(50);

                entity.Property(e => e.IngresosMensuales).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nombres).HasMaxLength(50);

                entity.Property(e => e.Profesion).HasMaxLength(50);
                entity.Property(e => e.IdVehiculo).HasColumnType("int");
            });

            modelBuilder.Entity<PersonasVehiculo>(entity =>
            {

                entity.HasIndex(e => e.IdVehiculo, "IX_PersonasVehiculos");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_PersonasVehiculos");

                entity.HasOne(d => d.IdVehiculoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehiculos_PersonasVehiculos");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.Property(e => e.Marca).HasMaxLength(50);

                entity.Property(e => e.Modelo).HasMaxLength(50);

                entity.Property(e => e.Placa).HasMaxLength(50);

                entity.Property(e => e.TipoVehiculo).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
