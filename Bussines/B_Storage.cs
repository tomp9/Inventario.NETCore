using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bussines
{
    public class B_Storage
    {
        public static void CreateItem(StorageEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWarehouse(string IdStorage) 
        {
            using (var b = new InventarioContext()) 
            {
                var product = b.Storages.ToList()
                    .Where(s => s.StorageId == IdStorage);
                
                return product.Any();
            }
        }

        public static List<StorageEntity> GetStorageProductByWarehouse(string idWarehouse)
        {
            using (var db = new InventarioContext())
            {
                return db.Storages
                    .Where(s=>s.WarehouseId == idWarehouse)
                    .Include(s => s.Product) //Entity Framework core 
                    .Include(s=> s.Warehouse)
                    .ToList();
            }
        }

        public static void DeleteItem(StorageEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Remove(item);
                db.SaveChanges();
            }
        }

        public static List<StorageEntity> ItemList()
        {
            using (var db = new InventarioContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void UpdateItem(StorageEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }
    }
}
