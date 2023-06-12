using MVC.Models;
using PortalCustomerManagmentChallangeEntity.Concrete;

namespace MVC.Business.Abstract
{
    public interface ICustomerService
    {
        Customer AddCustomer(Customer customer);
        List<User> GetAll();
    }
}
