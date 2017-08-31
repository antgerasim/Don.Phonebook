using System.Threading.Tasks;
using Abp.Application.Services;
using Don.Phonebook.Sessions.Dto;

namespace Don.Phonebook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
