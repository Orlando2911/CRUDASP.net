using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TCrud.Models;

public partial class TamtestContext : DbContext
{
    public TamtestContext()
    {
    }

    public TamtestContext(DbContextOptions<TamtestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Costumer> Costumers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Costumer>(entity =>
        {
            entity.ToTable("Costumer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.BorthDate)
                .HasColumnType("datetime")
                .HasColumnName("borth_date");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
