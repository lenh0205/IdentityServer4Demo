using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcClientTesting.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
