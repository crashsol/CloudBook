using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CloudBook.Authorization;
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
            Configuration.Authorization.Providers.Add<CloudBookAuthorizationProvider>();

            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                //添加书籍的映射              
                BookMapper.CreateMappers(configuration);


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
