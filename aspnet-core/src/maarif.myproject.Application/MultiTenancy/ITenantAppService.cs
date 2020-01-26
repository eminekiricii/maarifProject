using Abp.Application.Services;
using Abp.Application.Services.Dto;
using maarif.myproject.MultiTenancy.Dto;

namespace maarif.myproject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

