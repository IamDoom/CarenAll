using CarenAll.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarenAll.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("login");
        }
    }
}
