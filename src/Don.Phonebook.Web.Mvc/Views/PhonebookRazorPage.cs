using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Don.Phonebook.Web.Views
{
    public abstract class PhonebookRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhonebookRazorPage()
        {
            LocalizationSourceName = PhonebookConsts.LocalizationSourceName;
        }
    }
}
