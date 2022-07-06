using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectWithDbContext.Models;

namespace ProjectWithDbContext.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager { get; set; }
        private SignInManager<IdentityUser> signInManager { get; set; }

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = vm.Email,
                    Email = vm.Email
                };
                var result = await userManager.CreateAsync(user, vm.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
