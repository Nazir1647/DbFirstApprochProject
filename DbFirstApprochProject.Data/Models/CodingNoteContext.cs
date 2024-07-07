using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirstApprochProject.Data.Models;

public partial class CodingNoteContext : DbContext
{
    public CodingNoteContext()
    {
    }

    public CodingNoteContext(DbContextOptions<CodingNoteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HeaderMenu> HeaderMenus { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<SubMenu> SubMenus { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HeaderMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK__HeaderMe__C99ED230CDD5B275");

            entity.ToTable("HeaderMenu");

            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedByName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdByName");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.MenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notes__3214EC0791A82746");

            entity.Property(e => e.Code).HasColumnType("text");
            entity.Property(e => e.CodeLanguage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedByName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdByName");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.HeaderData)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MenuId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParagaraphData).HasColumnType("text");
            entity.Property(e => e.SubMenuId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubMenu__3214EC0702A88E6D");

            entity.ToTable("SubMenu");

            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedByName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdByName");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.SubMenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__users__DD70126447EC039B");

            entity.ToTable("users");

            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
