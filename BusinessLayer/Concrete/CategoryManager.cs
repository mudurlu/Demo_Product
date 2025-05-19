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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.TGetById(id);
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.TDelete(entity);
        }

        public void TInsert(Category entity)
        {
            _categoryDAL.TInsert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.TUpdate(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDAL.TGetAll();
        }
    }
}
