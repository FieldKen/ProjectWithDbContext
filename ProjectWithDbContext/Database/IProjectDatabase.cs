using ProjectWithDbContext.Domain;

namespace ProjectWithDbContext.Database
{
    public interface IProjectDatabase
    {
        public IEnumerable<Profile> GetProfiles();
        public IEnumerable<Post> GetPosts();
        public IEnumerable<Comment> GetComments();

    }
}
