using Abp.Authorization;
using maarif.myproject.Authorization.Roles;
using maarif.myproject.Authorization.Users;

namespace maarif.myproject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
