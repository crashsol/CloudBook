using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CloudBook.Roles.Dto;

namespace CloudBook.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
