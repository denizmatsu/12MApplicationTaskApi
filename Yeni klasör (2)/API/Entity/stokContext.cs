using System;
using System.Collections.Generic;
using API.DTO.STI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Entity
{
    public partial class stokContext : DbContext
    {
        public stokContext()
        {
        }

        public stokContext(DbContextOptions<stokContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StiResponse> StiResponses { get; set; } = null!;
        public virtual DbSet<StkResponse> StkResponses { get; set; } = null!;

        public virtual DbSet<Sti> Stis { get; set; } = null!;
        public virtual DbSet<Stk> Stks { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=stok;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sti>(entity =>
            {
                entity.HasKey(e => new { e.EvrakNo, e.Tarih, e.IslemTur })
                    .HasName("pkSTI");

                entity.ToTable("STI");

                entity.Property(e => e.EvrakNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Birim)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Fiyat).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MalKodu)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Miktar).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Tutar).HasColumnType("numeric(25, 6)");
            });

            modelBuilder.Entity<Stk>(entity =>
            {
                entity.HasKey(e => e.MalKodu)
                    .HasName("pkSTK");

                entity.ToTable("STK");

                entity.Property(e => e.MalKodu)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MalAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
