using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using maarif.myproject.Roles.Dto;
using maarif.myproject.Users.Dto;

namespace maarif.myproject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
