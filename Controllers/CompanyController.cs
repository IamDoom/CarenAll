using CarenAll.data;
using Microsoft.AspNetCore.Mvc;

namespace CarenAll.Controllers
{
    [Route("Company")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly LoginDbContext _loginDbContext;
        private readonly AppDbContext _appDbContext;

        public CompanyController(LoginDbContext loginDbContext, AppDbContext appDbContext)
        {
            _loginDbContext = loginDbContext;
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            return View("Company");
        }
    }
}
