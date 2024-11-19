using Entities;
using Microsoft.EntityFrameworkCore;

namespace HkmrArabalar
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanı tablolarını burada tanımlayın
        public DbSet<Araçlar> Araçlar { get; set; }

     
        }
    }
}
