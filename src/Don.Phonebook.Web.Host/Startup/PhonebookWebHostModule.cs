using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.Phonebook.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.Phonebook.Web.Host.Startup
{
    [DependsOn(
       typeof(PhonebookWebCoreModule))]
    public class PhonebookWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhonebookWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhonebookWebHostModule).GetAssembly());
        }
    }
}
