using System.Threading.Tasks;
using Abp.Application.Services;
using maarif.myproject.Sessions.Dto;

namespace maarif.myproject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
