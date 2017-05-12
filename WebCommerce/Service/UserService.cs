using Model;
using Repository;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUserService : IQlService<ApplicationUser>
    {
        List<ApplicationUser> GetUsersByRoleName(string roleName);
        List<ApplicationUser> GetUsersByRoleName2(string roleName);
    }

    public class UserService : QlService<ApplicationUser>, IUserService
    {
        IUserRoleRepository _userRoleRepository;
        IRoleRepository _roleRepository;
        public UserService(IUserRepository userRepository, IUserRoleRepository userRoleRepository, IRoleRepository roleRepository ,IUnitOfWork unitOfWork)
        {
            this._repository = userRepository;
            this._userRoleRepository = userRoleRepository;
            this._roleRepository = roleRepository;
            this._unitOfWork = unitOfWork;
        }
        public List<ApplicationUser> GetUsersByRoleName(string roleName)
        {
            var role = _roleRepository.GetSingleByCondition(x => x.Name == roleName);
            if (role == null)
                return new List<ApplicationUser>();
            string roleId = role.Id;

            var userRolesContainRoleId = _userRoleRepository.GetMulti(userRole => userRole.RoleId == roleId);

            return _repository.GetMulti(
                user => userRolesContainRoleId.Any(userRole => userRole.UserId == user.Id)).ToList();
        }


        public List<ApplicationUser> GetUsersByRoleName2(string roleName)
        {
            var applicationUsers = _repository.GetAll() ;
            var roleId = _roleRepository.GetSingleByCondition(x => x.Name == roleName).Id;
            var userRoles = _userRoleRepository.GetAll();
            return (from user in applicationUsers
                    join userRole in userRoles on user.Id equals userRole.UserId
                    where userRole.RoleId == roleId
                    select user).ToList();
        }

    }
}
