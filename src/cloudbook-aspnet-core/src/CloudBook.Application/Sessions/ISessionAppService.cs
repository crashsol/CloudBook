using System.Threading.Tasks;
using Abp.Application.Services;
using CloudBook.Sessions.Dto;

namespace CloudBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
