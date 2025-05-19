using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        

        public List<Product> TGetAll()
        {
            return _productDAL.TGetAll();    
        }

        public Product TGetById(int id)
        {
            return _productDAL.TGetById(id);
        }

        public void TDelete(Product entity)
        {
            _productDAL.TDelete(entity);
        }

        public void TInsert(Product entity)
        {
            _productDAL.TInsert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDAL.TUpdate(entity);
        }
    }
}
