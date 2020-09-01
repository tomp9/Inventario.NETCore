using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines
{
    public class B_Product
    {
        public static void CreateItem(ProductEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(ProductEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Products.Remove(item);
                db.SaveChanges();
            }
        }

        public static List<ProductEntity> ItemList()
        {
            using (var db = new InventarioContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity GetById(string ItemId)
        {
            using (var db = new InventarioContext())
            {
                return db.Products.Find(ItemId);
            }
        }

        public static void UpdateItem(ProductEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Products.Update(item);
                db.SaveChanges();
            }
        }
    }
}
