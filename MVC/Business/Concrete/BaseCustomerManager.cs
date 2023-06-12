using MVC.Business.Abstract;
using MVC.Models;
using PortalCustomerManagmentChallangeBusiness.Abstract;
using PortalCustomerManagmentChallangeEntity.Concrete;
using PortalCustomerManagmentChallangeEntity.Dto;
using PortalCustomerManagmentChallangeMVC.Business.Abstract;

namespace MVC.Business.Concrete
{
    public class BaseCustomerManager : ICustomerService
    {
        private readonly IUserService _userService;
        private readonly IVerificationService _verificationService;
        public BaseCustomerManager(IUserService userService, IVerificationService verificationService)
        {
            _userService = userService;
            _verificationService = verificationService;
        }

        public Customer AddCustomer(Customer customer)
        {
            try
            {
                if (customer != null)
                {
                    var user = new RegisterDto
                    {
                        Name = customer.Name,
                        Surname = customer.Surname,
                        Email = customer.Email,
                        Password = customer.Password,
                        TCKN = customer.TCKN,
                        TCKNCheck = customer.TCKNCheck
                    };
                    if (customer.TCKNCheck == true && !string.IsNullOrEmpty(customer.TCKN))
                    {
                        var result = _verificationService.VerifyTCKN(customer);
                        if (result)
                        {
                            var addResult = _userService.Add(user);
                            if (addResult > 0)
                            {
                                return customer;
                            }
                        }
                    }
                    else
                    {
                        var addResult = _userService.Add(user);
                        if (addResult > 0)
                        {
                            return customer;
                        }
                    }
                }
                else
                {
                    return new Customer();
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<User> GetAll()
        {
            try
            {
                return _userService.GetList();
            }
            catch (Exception)
            {

            }
            return null;
        }
    }
}
