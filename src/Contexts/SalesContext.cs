﻿using bizsoft_4ss3ssm3n7.Models;
using Microsoft.EntityFrameworkCore;

namespace bizsoft_4ss3ssm3n7.Contexts
{
  public class SalesContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderLine> OrderLines { get; set; }

    public DbSet<Item> Items { get; set; }

    public DbSet<Material> Materials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql("server=localhost;database=sales;user=root;password=h3rm4nn");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Material>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Description).IsRequired();
      });

      modelBuilder.Entity<Client>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.FirstName).IsRequired();
        entity.Property(e => e.LastName).IsRequired();
      });

      modelBuilder.Entity<Order>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.HasOne(e => e.Client)
              .WithMany(c => c.Orders)
              .IsRequired();
      });

      modelBuilder.Entity<OrderLine>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Quantity).IsRequired();
        entity.HasOne(e => e.Item)
          .WithOne()
          .IsRequired();
        entity.HasOne(e => e.Order)
              .WithMany(o => o.OrderLines)
              .IsRequired();
      });

      modelBuilder.Entity<Item>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Description).IsRequired();
        entity.HasOne(e => e.Material)
              .WithOne()
              .IsRequired();
      });
    }
  }
}
