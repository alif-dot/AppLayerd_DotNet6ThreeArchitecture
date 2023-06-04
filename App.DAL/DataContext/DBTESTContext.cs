using System;
using System.Collections.Generic;
using App.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.DAL.DataContext
{
    public partial class DBTESTContext : DbContext
    {
        public DBTESTContext()
        {
        }

        public DBTESTContext(DbContextOptions<DBTESTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__employee__51C8DD7ABBF99236");

                entity.ToTable("employee");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
