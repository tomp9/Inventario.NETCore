using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventarioContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<WarehouseEntity> WarehouseEntities { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-2L7EJNA; Database=InventoryDb;User Id =sa; Password=12345678a");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategotyName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategotyName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategotyName = "Hogar" },
                new CategoryEntity { CategoryId = "PFR", CategotyName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategotyName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategotyName = "Videojuegos" }
                );
            modelBuilder.Entity<WarehouseEntity>().HasData(
                    new WarehouseEntity()
                    {
                        WarehouseId = Guid.NewGuid().ToString(),
                        WarehouseName = "Bodega Central",
                        WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540"
                    },
                    new WarehouseEntity()
                    {
                        WarehouseId = Guid.NewGuid().ToString(),
                        WarehouseName = "Bodega Norte",
                        WarehouseAddress = "4447 Dane Street, Yakima, WA 98908"
                    },
                    new WarehouseEntity()
                    {
                        WarehouseId = Guid.NewGuid().ToString(),
                        WarehouseName = "Third Warehouse",
                        WarehouseAddress = "3003 Arrowood Drive, Jacksonville, FL 32257"
                    }
                );
        }
    }
}
