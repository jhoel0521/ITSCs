using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ITSC.Models
{
    public partial class itscContext : DbContext
    {
        public itscContext()
        {
        }

        public itscContext(DbContextOptions<itscContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Consulta> Consultas { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Trabajadore> Trabajadores { get; set; }
        public virtual DbSet<Tramite> Tramites { get; set; }
        public virtual DbSet<Verificacion> Verificacions { get; set; }
        public virtual DbSet<VerificacionDum> VerificacionDa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;database=itsc;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.Idc)
                    .HasName("PK__Carreras__DC501A0D94765326");

                entity.Property(e => e.Idc)
                    .ValueGeneratedNever()
                    .HasColumnName("idc");

                entity.Property(e => e.NombreC)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreC");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.HasKey(e => e.Idc)
                    .HasName("PK__consulta__DC501A0D5C7E2B5D");

                entity.ToTable("consultas");

                entity.Property(e => e.Idc)
                    .ValueGeneratedNever()
                    .HasColumnName("idc");

                entity.Property(e => e.Carta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("carta");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Ide).HasColumnName("ide");

                entity.Property(e => e.Ids).HasColumnName("ids");

                entity.Property(e => e.Idt).HasColumnName("idt");

                entity.HasOne(d => d.IdeNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.Ide)
                    .HasConstraintName("FK__consultas__Estad__45F365D3");

                entity.HasOne(d => d.IdsNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.Ids)
                    .HasConstraintName("FK__consultas__ids__46E78A0C");

                entity.HasOne(d => d.IdtNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.Idt)
                    .HasConstraintName("FK__consultas__idt__47DBAE45");
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.IdE)
                    .HasName("PK__Estudian__DC501A2B198CE571");

                entity.Property(e => e.IdE)
                    .ValueGeneratedNever()
                    .HasColumnName("idE");

                entity.Property(e => e.Idc).HasColumnName("idc");

                entity.Property(e => e.Idp).HasColumnName("idp");

                entity.HasOne(d => d.IdcNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.Idc)
                    .HasConstraintName("FK__Estudiantes__idc__3D5E1FD2");

                entity.HasOne(d => d.IdpNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.Idp)
                    .HasConstraintName("FK__Estudiantes__idp__3C69FB99");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Idp)
                    .HasName("PK__Personas__DC501A0018E9506C");

                entity.Property(e => e.Idp)
                    .ValueGeneratedNever()
                    .HasColumnName("idp");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Ncell).HasColumnName("ncell");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Idr)
                    .HasName("PK__Roles__DC501A7EFD94B3C5");

                entity.Property(e => e.Idr)
                    .ValueGeneratedNever()
                    .HasColumnName("idr");

                entity.Property(e => e.Roll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roll");
            });

            modelBuilder.Entity<Trabajadore>(entity =>
            {
                entity.HasKey(e => e.Idt)
                    .HasName("PK__Trabajad__DC501A7C0018F0DE");

                entity.Property(e => e.Idt)
                    .ValueGeneratedNever()
                    .HasColumnName("idt");

                entity.Property(e => e.Contra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contra");

                entity.Property(e => e.Idp).HasColumnName("idp");

                entity.Property(e => e.Idr).HasColumnName("idr");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdpNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.Idp)
                    .HasConstraintName("FK__Trabajadore__idp__403A8C7D");

                entity.HasOne(d => d.IdrNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.Idr)
                    .HasConstraintName("FK__Trabajadore__idr__412EB0B6");
            });

            modelBuilder.Entity<Tramite>(entity =>
            {
                entity.HasKey(e => e.Idt)
                    .HasName("PK__Tramites__DC501A7CDFF41927");

                entity.Property(e => e.Idt)
                    .ValueGeneratedNever()
                    .HasColumnName("idt");

                entity.Property(e => e.NombreT)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreT");
            });

            modelBuilder.Entity<Verificacion>(entity =>
            {
                entity.HasKey(e => e.Idv)
                    .HasName("PK__verifica__DC501A7A604075BE");

                entity.ToTable("verificacion");

                entity.Property(e => e.Idv)
                    .ValueGeneratedNever()
                    .HasColumnName("idv");

                entity.Property(e => e.CartaRespuesta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cartaRespuesta");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FechaR).HasColumnType("date");

                entity.Property(e => e.Idc).HasColumnName("idc");

                entity.Property(e => e.Idtec).HasColumnName("idtec");

                entity.HasOne(d => d.IdcNavigation)
                    .WithMany(p => p.Verificacions)
                    .HasForeignKey(d => d.Idc)
                    .HasConstraintName("FK__verificacio__idc__4BAC3F29");

                entity.HasOne(d => d.IdtecNavigation)
                    .WithMany(p => p.Verificacions)
                    .HasForeignKey(d => d.Idtec)
                    .HasConstraintName("FK__verificac__idtec__4AB81AF0");
            });

            modelBuilder.Entity<VerificacionDum>(entity =>
            {
                entity.HasKey(e => e.Idvda)
                    .HasName("PK__verifica__25CD2C9F0BBBC151");

                entity.ToTable("verificacionDA");

                entity.Property(e => e.Idvda)
                    .ValueGeneratedNever()
                    .HasColumnName("idvda");

                entity.Property(e => e.CartaRespuesta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cartaRespuesta");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Fechafirma)
                    .HasColumnType("date")
                    .HasColumnName("fechafirma");

                entity.Property(e => e.Idt).HasColumnName("idt");

                entity.Property(e => e.Idv).HasColumnName("idv");

                entity.HasOne(d => d.IdtNavigation)
                    .WithMany(p => p.VerificacionDa)
                    .HasForeignKey(d => d.Idt)
                    .HasConstraintName("FK__verificacio__idt__4F7CD00D");

                entity.HasOne(d => d.IdvNavigation)
                    .WithMany(p => p.VerificacionDa)
                    .HasForeignKey(d => d.Idv)
                    .HasConstraintName("FK__verificacio__idv__4E88ABD4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
