using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.Phonebook.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.Phonebook.Web.Startup
{
    [DependsOn(typeof(PhonebookWebCoreModule))]
    public class PhonebookWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhonebookWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<PhonebookNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhonebookWebMvcModule).GetAssembly());
        }
    }
}