using Microsoft.EntityFrameworkCore;

namespace Usermanagement.Models
{

        public class AppDBContext : DbContext
        {
            public AppDBContext(DbContextOptions<AppDBContext> options)
                : base(options) { }

            public DbSet<User> User { get; set; }
        }
}
