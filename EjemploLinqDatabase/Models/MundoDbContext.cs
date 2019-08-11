using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EjemploLinqDatabase.Models
{
    public partial class MundoDbContext : DbContext
    {
        public MundoDbContext()
        {
        }

        public MundoDbContext(DbContextOptions<MundoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pais> Pais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=4040;database=mundo;user=root;password=telesca1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.ToTable("pais", "mundo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iso)
                    .HasColumnName("iso")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });
        }
    }
}
