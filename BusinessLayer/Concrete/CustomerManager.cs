using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;
        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }
        public Customer TGetById(int id)
        {
            return _customerDAL.TGetById(id);
        }
        public void TDelete(Customer entity)
        {
            _customerDAL.TDelete(entity);
        }
        public void TInsert(Customer entity)
        {
            _customerDAL.TInsert(entity);
        }
        public void TUpdate(Customer entity)
        {
            _customerDAL.TUpdate(entity);
        }
        public List<Customer> TGetAll()
        {
            return _customerDAL.TGetAll();
        }
    }
   
}
