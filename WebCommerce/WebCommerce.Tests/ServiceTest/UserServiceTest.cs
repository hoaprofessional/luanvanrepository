using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using Repository.Infrastructure;
using Repository;

namespace WebCommerce.Tests.ServiceTest
{
    [TestClass]
    public class UserServiceTest
    {
        IUserService _userService;
        public UserServiceTest()
        {
            IDbFactory dbFactory = new DbFactory();
            IUnitOfWork unitOfWork = new UnitOfWork(dbFactory);
            IUserRepository userRepository = new UserRepository(dbFactory);
            IUserRoleRepository userRoleRepository = new UserRoleRepository(dbFactory);
            IRoleRepository roleRepository = new RoleRepository(dbFactory);
            _userService = new UserService(userRepository, userRoleRepository, roleRepository, unitOfWork);
        }
    
        [TestMethod]
        public void GetUsersByRoleName()
        {
        //    Assert.Equals(1, _userService.GetUsersByRoleName("Admin").Count);
        }
    }
}
