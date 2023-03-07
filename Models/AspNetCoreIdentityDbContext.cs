using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
 
using Microsoft.EntityFrameworkCore;

namespace Core_API_Postgre_Identity.Models
{
    public class AspNetCoreIdentityDbContext : IdentityDbContext
    {
        public AspNetCoreIdentityDbContext(DbContextOptions<AspNetCoreIdentityDbContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
