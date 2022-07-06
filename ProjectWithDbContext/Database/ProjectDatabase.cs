using ProjectWithDbContext.Domain;

namespace ProjectWithDbContext.Database
{
    public class ProjectDatabase : IProjectDatabase
    {
        private ProjectDbContext projectDbContext { get; set; }

        public ProjectDatabase(ProjectDbContext projectDbContext)
        {
            this.projectDbContext = projectDbContext;
        }

        public IEnumerable<Profile> GetProfiles()
        {
            return projectDbContext.Profiles;
        }

        public IEnumerable<Post> GetPosts()
        {
            return projectDbContext.Posts;
        }

        public IEnumerable<Comment> GetComments()
        {
            return projectDbContext.Comments;
        }
    }
}
