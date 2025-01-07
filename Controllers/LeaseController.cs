using Microsoft.AspNetCore.Mvc;

namespace CarenAll.Controllers
{
    public class LeaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
