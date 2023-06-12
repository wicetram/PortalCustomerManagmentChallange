using PortalCustomerManagmentChallangeBusiness.Abstract;
using PortalCustomerManagmentChallangeDataAccess.Abstract;
using PortalCustomerManagmentChallangeEntity.Concrete;
using PortalCustomerManagmentChallangeEntity.Dto;

namespace PortalCustomerManagmentChallangeBusiness.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public int Add(RegisterDto registerDto)
        {
            try
            {
                var user = CreateUser(registerDto);
                return _userDal.Add(user);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private static User CreateUser(RegisterDto registerDto)
        {
            try
            {
                if (registerDto.TCKNCheck == true)
                {
                    return new User()
                    {
                        Email = registerDto.Email,
                        Name = registerDto.Name,
                        Surname = registerDto.Surname,
                        Password = registerDto.Password,
                        TCKN = registerDto.TCKN,
                        TCKNCheck = true
                    };
                }
                else
                {
                    return new User()
                    {
                        Email = registerDto.Email,
                        Name = registerDto.Name,
                        Surname = registerDto.Surname,
                        Password = registerDto.Password,
                        TCKN = registerDto.TCKN,
                        TCKNCheck = false
                    };
                }
            }
            catch (Exception)
            {

            }
            return new User();
        }

        public User GetByTCKN(string TCKN)
        {
            try
            {
                return _userDal.Get(p => p.TCKN == TCKN);
            }
            catch (Exception)
            {

            }
            return null;
        }

        public List<User> GetList()
        {
            try
            {
                return _userDal.GetAll();
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
