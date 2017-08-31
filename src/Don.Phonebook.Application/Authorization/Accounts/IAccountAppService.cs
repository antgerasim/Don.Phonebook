using System.Threading.Tasks;
using Abp.Application.Services;
using Don.Phonebook.Authorization.Accounts.Dto;

namespace Don.Phonebook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
