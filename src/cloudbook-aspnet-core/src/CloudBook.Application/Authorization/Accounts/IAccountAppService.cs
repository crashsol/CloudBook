using System.Threading.Tasks;
using Abp.Application.Services;
using CloudBook.Authorization.Accounts.Dto;

namespace CloudBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
