using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CloudBook.MultiTenancy.Dto;

namespace CloudBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
