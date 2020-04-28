using Microsoft.EntityFrameworkCore;

namespace BankServices
{
    public class Hello
    {

    }
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hello> Hellos{ get; set; }
    }
}