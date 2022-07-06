using Microsoft.AspNetCore.Mvc;
using ProjectWithDbContext.Database;
using ProjectWithDbContext.Models;
using System.Diagnostics;

namespace ProjectWithDbContext.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProjectDatabase projectDatabase;

        public HomeController(ILogger<HomeController> logger, ProjectDatabase projectDatabase)
        {
            _logger = logger;
            this.projectDatabase = projectDatabase;
        }

        public IActionResult Index()
        {
            var profiles = projectDatabase.GetProfiles().Select(x=> new ProfileViewModel { UserName = x.UserName});
            var comments = projectDatabase.GetComments().Select(x => new CommentViewModel { Content = x.Content });
            var posts = projectDatabase.GetPosts().Select(x => new PostViewModel { Title = x.Title, Message = x.Message });

            var vm = new SummaryProfileViewModel
            {
                PostViewModels = posts,
                CommentViewModels = comments,
                ProfileViewModels = profiles
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}