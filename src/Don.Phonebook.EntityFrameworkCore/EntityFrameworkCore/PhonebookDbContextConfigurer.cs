using Microsoft.EntityFrameworkCore;

namespace Don.Phonebook.EntityFrameworkCore
{
    public static class PhonebookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhonebookDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}