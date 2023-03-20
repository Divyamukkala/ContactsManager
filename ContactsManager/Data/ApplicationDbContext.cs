using ContactsManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Contacts> Contacts { get; set; }

    }
}
