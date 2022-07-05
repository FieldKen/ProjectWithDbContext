using Microsoft.EntityFrameworkCore;

namespace ProjectWithDbContext.Database
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }
    }
}
