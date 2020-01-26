using System.Threading.Tasks;
using Abp.Application.Services;
using maarif.myproject.Authorization.Accounts.Dto;

namespace maarif.myproject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
