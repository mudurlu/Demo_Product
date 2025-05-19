using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void TInsert(T p);
        void TUpdate(T p);
        void TDelete(T p);
        List<T> TGetAll();
        T TGetById(int id);
    }   
}
