using Abp.Zero.EntityFrameworkCore;
using Don.Phonebook.Authorization.Roles;
using Don.Phonebook.Authorization.Users;
using Don.Phonebook.MultiTenancy;
using Don.Phonebook.Persons;
using Microsoft.EntityFrameworkCore;

namespace Don.Phonebook.EntityFrameworkCore
{
    public class PhonebookDbContext : AbpZeroDbContext<Tenant, Role, User, PhonebookDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        public virtual DbSet<Person> Persons { get; set; }
        
        public PhonebookDbContext(DbContextOptions<PhonebookDbContext> options)
            : base(options)
        {
            
        }
    }
}
