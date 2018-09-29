namespace Infraestructure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataFullCar : DbContext
    {
        public DataFullCar()
            : base("name=DataFullCar")
        {
        }

        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Lavador> Lavador { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<venta> venta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .Property(e => e.aut_Placa)
                .IsUnicode(false);

            modelBuilder.Entity<Auto>()
                .Property(e => e.aut_color)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Auto)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.aut_id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.venta)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.ven_id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lavador>()
                .Property(e => e.lav_telefono)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Lavador>()
                .HasMany(e => e.Turno)
                .WithRequired(e => e.Lavador)
                .HasForeignKey(e => e.tur_id_lavador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lavador>()
                .HasMany(e => e.venta)
                .WithRequired(e => e.Lavador)
                .HasForeignKey(e => e.ven_id_lavador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.ser_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.ser_tipovehiculo)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.venta)
                .WithOptional(e => e.Servicio)
                .HasForeignKey(e => e.ven_ser_tiposervicio);

            modelBuilder.Entity<venta>()
                .Property(e => e.adicional)
                .IsUnicode(false);
        }
    }
}
