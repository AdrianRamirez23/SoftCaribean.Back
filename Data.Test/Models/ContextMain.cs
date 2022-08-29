using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Test.Models
{
    public partial class ContextMain : DbContext
    {
        public ContextMain()
        {
        }

        public ContextMain(DbContextOptions<ContextMain> options)
            : base(options)
        {
        }

        public virtual DbSet<DataMaestra> DataMaestras { get; set; }
        public virtual DbSet<Maestra> Maestras { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SoftCaribean;Data Source=DESKTOP-Q1UFNOP");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataMaestra>(entity =>
            {
                entity.HasKey(e => e.Nmdato);

                entity.Property(e => e.Nmdato)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmdato");

                entity.Property(e => e.Cadato1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cadato1");

                entity.Property(e => e.Cddato)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cddato");

                entity.Property(e => e.Cddato2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cddato2");

                entity.Property(e => e.Cddato3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cddato3");

                entity.Property(e => e.Febaja)
                    .HasColumnType("datetime")
                    .HasColumnName("febaja");

                entity.Property(e => e.Feregistro)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("feregistro");

                entity.Property(e => e.Nmmaestro)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmmaestro");

                entity.HasOne(d => d.NmmaestroNavigation)
                    .WithMany(p => p.DataMaestras)
                    .HasForeignKey(d => d.Nmmaestro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK01_DataMaestra_Maestras");
            });

            modelBuilder.Entity<Maestra>(entity =>
            {
                entity.HasKey(e => e.Nmmaestro);

                entity.HasIndex(e => e.Nmmaestro, "IX_Maestras")
                    .IsUnique();

                entity.Property(e => e.Nmmaestro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmmaestro");

                entity.Property(e => e.Cdmaestro)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdmaestro");

                entity.Property(e => e.Dsmaestro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsmaestro");

                entity.Property(e => e.Febaja)
                    .HasColumnType("datetime")
                    .HasColumnName("febaja");

                entity.Property(e => e.Feregistro)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("feregistro");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.Nmid);

                entity.HasIndex(e => e.Nmid, "IX_Pacientes")
                    .IsUnique();

                entity.Property(e => e.Nmid)
                    .ValueGeneratedNever()
                    .HasColumnName("nmid");

                entity.Property(e => e.Cduusuario)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cduusuario");

                entity.Property(e => e.Dsarl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsarl");

                entity.Property(e => e.Dscondicion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dscondicion");

                entity.Property(e => e.Dseps)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dseps");

                entity.Property(e => e.Febaja)
                    .HasColumnType("datetime")
                    .HasColumnName("febaja");

                entity.Property(e => e.Feregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("feregistro");

                entity.Property(e => e.NmidMedicotra).HasColumnName("nmid_medicotra");

                entity.Property(e => e.NmidPersona).HasColumnName("nmid_persona");

                entity.HasOne(d => d.NmidMedicotraNavigation)
                    .WithMany(p => p.PacienteNmidMedicotraNavigations)
                    .HasForeignKey(d => d.NmidMedicotra)
                    .HasConstraintName("FK01_Pacientes_Personas");

                entity.HasOne(d => d.NmidPersonaNavigation)
                    .WithMany(p => p.PacienteNmidPersonaNavigations)
                    .HasForeignKey(d => d.NmidPersona)
                    .HasConstraintName("FK02_Pacientes_Personas");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Nmid);

                entity.HasIndex(e => e.Nmid, "IX_Personas")
                    .IsUnique();

                entity.Property(e => e.Nmid).HasColumnName("nmid");

                entity.Property(e => e.Cddocumento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cddocumento");

                entity.Property(e => e.Cdgenero)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdgenero");

                entity.Property(e => e.CdtelefonoMovil)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdtelefono_movil");

                entity.Property(e => e.CdtelfonoFijo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdtelfono_fijo");

                entity.Property(e => e.Cdtipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdtipo");

                entity.Property(e => e.Cdusuario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cdusuario");

                entity.Property(e => e.Dsapellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsapellidos");

                entity.Property(e => e.Dsdireccion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dsdireccion");

                entity.Property(e => e.Dsemail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dsemail");

                entity.Property(e => e.Dsnombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsnombres");

                entity.Property(e => e.Dsphoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsphoto");

                entity.Property(e => e.Febaja)
                    .HasColumnType("datetime")
                    .HasColumnName("febaja");

                entity.Property(e => e.Fenacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fenacimiento");

                entity.Property(e => e.Feregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("feregistro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
