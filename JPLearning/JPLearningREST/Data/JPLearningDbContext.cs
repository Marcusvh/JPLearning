using Microsoft.EntityFrameworkCore;

namespace JPLearningREST.Data
{
    public class JPLearningDbContext : DbContext
    {
        public JPLearningDbContext(DbContextOptions<JPLearningDbContext> options) : base(options) { }

        
    }
}
