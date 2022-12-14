using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh_c021ht.Models;

public partial class SailorsContext : DbContext
{
    public SailorsContext()
    {
    }

    public SailorsContext(DbContextOptions<SailorsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Boat> Boat { get; set; }

    public virtual DbSet<Order> Order { get; set; }

    public virtual DbSet<Owner> Owner { get; set; }

    public virtual DbSet<Sails> Sails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\c021ht\\Desktop\\zh-c021ht\\zh-c021ht\\Sailortailor.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Boat>(entity =>
        {
            entity.Property(e => e.BoatId)
                .ValueGeneratedNever()
                .HasColumnName("BoatID");
            entity.Property(e => e.BoatName).HasMaxLength(60);
            entity.Property(e => e.OwnerFk).HasColumnName("OwnerFK");

            entity.HasOne(d => d.OwnerFkNavigation).WithMany(p => p.Boat)
                .HasForeignKey(d => d.OwnerFk)
                .HasConstraintName("FK_Boat_ToOwner");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Db).HasColumnName("db");
            entity.Property(e => e.SailsFk).HasColumnName("SailsFK");

            entity.HasOne(d => d.BoatFkNavigation).WithMany(p => p.Order)
                .HasForeignKey(d => d.BoatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_ToBoat");

            entity.HasOne(d => d.OwnerFkNavigation).WithMany(p => p.Order)
                .HasForeignKey(d => d.OwnerFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_ToOwner");

            entity.HasOne(d => d.SailsFkNavigation).WithMany(p => p.Order)
                .HasForeignKey(d => d.SailsFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_ToSails");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.Property(e => e.OwnerId)
                .ValueGeneratedNever()
                .HasColumnName("OwnerID");
            entity.Property(e => e.ContactPhone).HasMaxLength(12);
            entity.Property(e => e.Name).HasMaxLength(60);
        });

        modelBuilder.Entity<Sails>(entity =>
        {
            entity.HasKey(e => e.SailId).HasName("PK_Sail");

            entity.Property(e => e.SailId)
                .ValueGeneratedNever()
                .HasColumnName("SailID");
            entity.Property(e => e.Db).HasColumnName("db");
            entity.Property(e => e.SailName).HasMaxLength(60);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
