using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CloudBook.Authorization;
using CloudBook.Books.Authorization;
using CloudBook.Books.Mapper;

namespace CloudBook
{
    [DependsOn(
        typeof(CloudBookCoreModule),
        typeof(AbpAutoMapperModule))]
    public class CloudBookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //系统权限添加
            Configuration.Authorization.Providers.Add<CloudBookAuthorizationProvider>();
            //添加权限配置
            Configuration.Authorization.Providers.Add<BookAuthorizationProvider>();

            Configuration.Authorization.Providers.Add<BookTagAuthorizationProvider>();

            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {

                BookMapper.CreateMappings(configuration);
                BookTagMapper.CreateMappings(configuration);

            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CloudBookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)                
            );
        }
    }
}
