using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Don.Phonebook.Configuration.Dto;

namespace Don.Phonebook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhonebookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
