
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OAuth.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult OnPost()
        {
            var login = Request.Form["login"];
            var returnUrl = Request.Form["returnUrl"];
            var list = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "test user"),
                new Claim(ClaimTypes.Email, login),

            };
            // do something with emailAddress
            var identity = new ClaimsIdentity(list, "default");
            var principal = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(principal);
            return RedirectToRoute(returnUrl);
        }
    }
}
