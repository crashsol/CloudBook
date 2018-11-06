using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CloudBook.Controllers
{
    public abstract class CloudBookControllerBase: AbpController
    {
        protected CloudBookControllerBase()
        {
            LocalizationSourceName = CloudBookConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
