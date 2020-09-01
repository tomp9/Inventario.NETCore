using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines
{
    public class B_InputOuput
    {
        public void CreateItem(InputOutputEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.InOuts.Add(item);
                db.SaveChanges();
            }
        }

        public void DeleteItem(InputOutputEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.InOuts.Remove(item);
                db.SaveChanges();
            }
        }

        public List<InputOutputEntity> ItemList()
        {
            using (var db = new InventarioContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void UpdateItem(InputOutputEntity item)
        {
            using (var db = new InventarioContext())
            {
                db.InOuts.Update(item);
                db.SaveChanges();
            }
        }
    }
}
