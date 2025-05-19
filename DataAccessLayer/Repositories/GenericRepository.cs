using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concete;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        Context c = new Context();
        public void Delete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
           return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return c.Set<T>().ToList();
        }

        public void Insert(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }

        public void Update(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
    }
}
