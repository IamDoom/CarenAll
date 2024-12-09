using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CarenAll.Models
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options): base(options) 
        { 
        
        
        }

        public DbSet<DCandidate>DCandidates { get; set; }   
    }
}
