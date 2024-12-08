using Microsoft.EntityFrameworkCore;
using CarenAll.Models;

namespace CarenAll.data
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options) { }
        public DbSet<Credentials> Credentials {  get; set; }


    }
}
