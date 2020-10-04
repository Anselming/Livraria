using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.Utilitario
{
   public static class ListExtensions
    {
       public static List<T> CloneList<T>(this List<T> list) where T: ICloneable
       {
           List<T> clonedList = new List<T>();
           foreach (T t in list)
           {
               clonedList.Add((T)t.Clone());
           }

           return clonedList;
       }

       public static int GetHashCode<T>(this List<T> l)
       {
           int hash = 0;
           foreach (T item in l)
           {
               hash ^= item.GetHashCode();
           }

           return hash;
       }

    }
}
