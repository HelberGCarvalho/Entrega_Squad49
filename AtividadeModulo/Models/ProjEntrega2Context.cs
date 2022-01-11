using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class ProjEntrega2Context : DbContext
    {

        public ProjEntrega2Context(DbContextOptions<ProjEntrega2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(local);Database=ProjEntrega2;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.IdContato)
                    .HasName("PK__Contato__3D4FFC56C47B47C8");

                entity.ToTable("Contato");

                entity.HasIndex(e => e.Empresa, "UQ__Contato__C322C24C63223735")
                    .IsUnique();

                entity.Property(e => e.IdContato).HasColumnName("id_contato");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("comentarios");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sobrenome");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
