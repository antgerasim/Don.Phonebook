using System.Threading.Tasks;
using Don.Phonebook.Configuration.Dto;

namespace Don.Phonebook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}