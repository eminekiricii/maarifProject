using System.Threading.Tasks;
using maarif.myproject.Configuration.Dto;

namespace maarif.myproject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
