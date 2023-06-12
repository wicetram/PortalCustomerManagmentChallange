using MVC.Models;

namespace PortalCustomerManagmentChallangeMVC.Business.Abstract
{
    public interface IVerificationService
    {
        bool VerifyTCKN(Customer customer);
    }
}
