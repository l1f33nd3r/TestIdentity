using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OAuth.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
       

        [Authorize]
        protected IActionResult Index()
        {
            return View();
        }
    }
}
