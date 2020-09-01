using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines
{
    public class B_Category 
    {
        public static void CreateItem(CategoryEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(CategoryEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Categories.Remove(item);
                db.SaveChanges();
            }
        }

        public static List<CategoryEntity> ItemList()
        {
            using (var db = new InventarioContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity GetItemById(string ItemId)
        {
            using (var db = new InventarioContext())
            {
                return db.Categories.Find(ItemId);
            }
        }

        public static void UpdateItem(CategoryEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }
    }
}
