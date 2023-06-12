using PortalCustomerManagmentChallangeCore.DataAccess;
using PortalCustomerManagmentChallangeEntity.Concrete;

namespace PortalCustomerManagmentChallangeDataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
