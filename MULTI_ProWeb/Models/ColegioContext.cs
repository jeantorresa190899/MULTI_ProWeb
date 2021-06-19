using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MULTI_ProWeb.Models
{
    public partial class ColegioContext : DbContext
    {
        public ColegioContext()
        {
        }

        public ColegioContext(DbContextOptions<ColegioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }
        public virtual DbSet<Entrega> Entregas { get; set; }
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Tortum> Torta { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LENOVO-X220;Initial Catalog=PASTELERIA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__CATEGORI__4BD51FA55B2FD00D");

                entity.ToTable("CATEGORIA");

                entity.Property(e => e.IdCategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTE__23A341303012E487");

                entity.ToTable("CLIENTE");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.Correo)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DOMICILIO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.IdTorta })
                    .HasName("PK__DETALLE___0999758FB313BC03");

                entity.ToTable("DETALLE_PEDIDO");

                entity.Property(e => e.IdPedido)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdTorta)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_TORTA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__ID_PE__36B12243");

                entity.HasOne(d => d.IdTortaNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdTorta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__ID_TO__37A5467C");
            });

            modelBuilder.Entity<Entrega>(entity =>
            {
                entity.HasKey(e => e.IdEntrega)
                    .HasName("PK__ENTREGA__2BD5DB9CEE89B55A");

                entity.ToTable("ENTREGA");

                entity.Property(e => e.IdEntrega)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ENTREGA");

                entity.Property(e => e.Monto).HasColumnName("MONTO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PK__METODO_P__B68D23DF33053788");

                entity.ToTable("METODO_PAGO");

                entity.Property(e => e.IdPago)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PAGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__PEDIDO__A05C2F2ACA73E858");

                entity.ToTable("PEDIDO");

                entity.Property(e => e.IdPedido)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_PEDIDO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_EMISION");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEntrega).HasColumnName("ID_ENTREGA");

                entity.Property(e => e.IdPago).HasColumnName("ID_PAGO");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MONTO_TOTAL");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__PEDIDO__ID_CLIEN__32E0915F");

                entity.HasOne(d => d.IdEntregaNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdEntrega)
                    .HasConstraintName("FK__PEDIDO__ID_ENTRE__31EC6D26");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdPago)
                    .HasConstraintName("FK__PEDIDO__ID_PAGO__33D4B598");
            });

            modelBuilder.Entity<Tortum>(entity =>
            {
                entity.HasKey(e => e.IdTorta)
                    .HasName("PK__TORTA__9C55AA5B65434D13");

                entity.ToTable("TORTA");

                entity.Property(e => e.IdTorta)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_TORTA");

                entity.Property(e => e.Color)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Dedicatoria)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DEDICATORIA");

                entity.Property(e => e.Dimension)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DIMENSION");

                entity.Property(e => e.Ganache)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("GANACHE");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PRECIO");

                entity.Property(e => e.Relleno)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("RELLENO");

                entity.Property(e => e.Sabor)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("SABOR");

                entity.Property(e => e.Tamaño)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TAMAÑO");

                entity.Property(e => e.Topping)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TOPPING");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Torta)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__TORTA__ID_CATEGO__2B3F6F97");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__91136B90067D071D");

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__USUARIO__ID_CLIE__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
