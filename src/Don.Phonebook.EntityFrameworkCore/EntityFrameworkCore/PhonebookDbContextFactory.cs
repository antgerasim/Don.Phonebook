using Don.Phonebook.Configuration;
using Don.Phonebook.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Don.Phonebook.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhonebookDbContextFactory : IDbContextFactory<PhonebookDbContext>
    {
        public PhonebookDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<PhonebookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhonebookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhonebookConsts.ConnectionStringName));
            
            return new PhonebookDbContext(builder.Options);
        }
    }
}