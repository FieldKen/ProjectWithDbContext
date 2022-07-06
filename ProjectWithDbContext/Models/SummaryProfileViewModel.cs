namespace ProjectWithDbContext.Models
{
    public class SummaryProfileViewModel
    {
        public IEnumerable<ProfileViewModel> ProfileViewModels { get; set; }
        public IEnumerable<PostViewModel> PostViewModels { get; set; }
        public IEnumerable<CommentViewModel> CommentViewModels { get; set; }
    }
}
