using Abp.Authorization;
using Abp.Localization;
using CloudBook.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CloudBook.Books.Authorization
{
    /// <summary>
    /// 书籍管理授权管理Provider
    /// </summary>
    public class BookAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //判断权限列表是否添加了根节点
            var pages = context.GetPermissionOrNull(PermissionNames.Pages) ?? context.CreatePermission(PermissionNames.Pages, L("Pgaes"));
            //管理员权限节点是否已经创建
            var admin = pages.Children.FirstOrDefault(b => b.Name == PermissionNames.Pages_Administrator) ?? pages.CreateChildPermission(PermissionNames.Pages_Administrator, L(PermissionNames.Pages_Administrator));

            //添加书籍管理的权限控制
            var bookPermission = admin.CreateChildPermission(BookPermissions.BookManager, L("BookManager"));

            bookPermission.CreateChildPermission(BookPermissions.Query, L("Query"));
            bookPermission.CreateChildPermission(BookPermissions.Create, L("Create"));
            bookPermission.CreateChildPermission(BookPermissions.Edit, L("Edit"));            
            bookPermission.CreateChildPermission(BookPermissions.Delete, L("Delete"));
            bookPermission.CreateChildPermission(BookPermissions.BatchDelete, L("BatchDelete"));


        }

        /// <summary>
        /// 多语言转义
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ILocalizableString L(string name)
        {
            return new LocalizableString(name,CloudBookConsts.LocalizationSourceName);
        }
    }
}
