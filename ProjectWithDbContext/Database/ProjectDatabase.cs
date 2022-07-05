namespace ProjectWithDbContext.Database
{
    public class ProjectDatabase : IProjectDatabase
    {
        private ProjectDbContext projectDbContext { get; set; }

        public ProjectDatabase(ProjectDbContext projectDbContext)
        {
            this.projectDbContext = projectDbContext;
        }
    }
}
