using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.Phonebook.MultiTenancy.Dto;

namespace Don.Phonebook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
