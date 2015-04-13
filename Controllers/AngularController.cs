using Microsoft.AspNet.Identity;
using hello_web_app.Infrastructure.Security;

namespace hello_web_app.Controllers
{
    public class AngularController
    {
		public AngularController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
		{

		}
    }
}