using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
    public interface ICRUData<T>
    {
        static List<T> ItemList { get; }

        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
    }
}
