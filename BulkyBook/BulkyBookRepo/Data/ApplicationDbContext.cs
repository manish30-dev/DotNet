using BulkyBookRepo.Model;

using Microsoft.EntityFrameworkCore;
namespace BulkyBookRepo.Data
    
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category>? Categories { get; set; } 
    }
}
