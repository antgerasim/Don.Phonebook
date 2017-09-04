using System.Reflection;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.Phonebook.Authorization;
using Don.Phonebook.Roles.Dto;

namespace Don.Phonebook
{
    [DependsOn(
        typeof(PhonebookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhonebookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhonebookAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(PhonebookApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
                //Don mappings
                cfg.CreateMap<Permission, PermissionDto>().ForMember(p => p.Parent,
                    option => option.MapFrom(entity => entity.Parent.ToString()));

            });
        }
    }
}