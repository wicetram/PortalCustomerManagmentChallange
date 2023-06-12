using PortalCustomerManagmentChallangeCore.DataAccess.EntityFramework;
using PortalCustomerManagmentChallangeDataAccess.Abstract;
using PortalCustomerManagmentChallangeDataAccess.Concrete.EntityFramework.Context;
using PortalCustomerManagmentChallangeEntity.Concrete;

namespace PortalCustomerManagmentChallangeDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, SimpleContextDb>, IUserDal
    {
    }
}
