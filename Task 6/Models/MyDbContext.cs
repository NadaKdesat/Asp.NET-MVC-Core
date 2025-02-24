using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Task_6.Models;

public partial class MyDbContext : DbContext
//DbContext is a basic class provided by Entity Framework that gives you the core functionality to interact with the database.
//DbContext is the core element that enables interaction with the database using the Entity Framework.
//MyDbContext is a custom class (inherits from DbContext) that defines and sets up the entities(like tables) you will be working with in the database.
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-GTJ4IDU;Database=ShopDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC27DD57F439");

            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 3)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
