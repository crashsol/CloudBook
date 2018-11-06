using Abp.Authorization;
using CloudBook.Authorization.Roles;
using CloudBook.Authorization.Users;

namespace CloudBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
