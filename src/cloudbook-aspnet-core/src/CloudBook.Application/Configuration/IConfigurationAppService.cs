using System.Threading.Tasks;
using CloudBook.Configuration.Dto;

namespace CloudBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
