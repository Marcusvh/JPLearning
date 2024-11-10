using JPLearningLib.models;
using Microsoft.EntityFrameworkCore;

namespace JPLearningREST.Data
{
    public class JPLearningDbContext : DbContext
    {
        public JPLearningDbContext(DbContextOptions<JPLearningDbContext> options) : base(options) { }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
