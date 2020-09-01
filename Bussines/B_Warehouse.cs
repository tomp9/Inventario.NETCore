using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines
{
    public class B_Warehouse
    {
        public static void CreateItem(WarehouseEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.WarehouseEntities.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(WarehouseEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.WarehouseEntities.Remove(item);
                db.SaveChanges();
            }
        }

        public static List<WarehouseEntity> ItemList()
        {
            using (var db = new InventarioContext())
            {
                return db.WarehouseEntities.ToList();
            }
        }

        public static void UpdateItem(WarehouseEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.WarehouseEntities.Update(item);
                db.SaveChanges();
            }
        }
    }
}
