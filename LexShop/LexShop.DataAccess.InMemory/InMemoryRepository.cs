using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using LexShop.Core.Models;
namespace LexShop.DataAccess.InMemory
{
   public class InMemoryRepository<T> where T : BaseEntity
    {
        ObjectCache cache = MemoryCache.Default;
        List<T> items;
        string className;

        public InMemoryRepository()
        {
            className = typeof(T).Name;
            items = cache[className] as List<T>;
            if ( items == null)
            {
                items = new List<T>();
            }
        }
        public void commit()
        {
            cache[className] = items;
        }
        public void insert(T t)
        {
            items.Add(t);
        }
        public void Update(T t)
        {
            T tToupdate = items.Find(i => i.Id== t.Id);
            if (tToupdate != null )
            {
                tToupdate = t;
            }
            else
            {
                throw new Exception(className + "Not Found");
            }
        }
        public T Find(string Id)
        {
            T t = items.Find(i => i.Id == Id);
            if (t != null)
            {
                return t;
            }
            else
            {
                throw new Exception(className + "Not Found");
            }
                
        }
        public IQueryable<T> Collection()
        {
            return items.AsQueryable();
        }
        public void Delete(string Id)
        {
            T tDelete = items.Find(i => i.Id == Id);
            if (tDelete != null)
            {
                items.Remove(tDelete);
            }
            else
            {
                throw new Exception(className + "Not Found");
            }
        }
    }
}
