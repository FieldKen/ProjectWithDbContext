using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWithDbContext.Domain;

namespace ProjectWithDbContext.Database
{
    public class ProjectDbContext : IdentityDbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            Profiles.Add(new Profile { UserName = "Ken", Adres = "Bla" });
            Profiles.Add(new Profile { UserName = "Thomas", Adres = "Bla" });
            Posts.Add(new Post { Title = "Hallo", Message = "Plezant" });
            Comments.Add(new Comment { Content = "Leuke comments" });
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
