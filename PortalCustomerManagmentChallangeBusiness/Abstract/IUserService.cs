using PortalCustomerManagmentChallangeEntity.Concrete;
using PortalCustomerManagmentChallangeEntity.Dto;

namespace PortalCustomerManagmentChallangeBusiness.Abstract
{
    public interface IUserService
    {
        int Add(RegisterDto registerDto);
        List<User> GetList();
        User GetByTCKN(string TCKN);
    }
}
