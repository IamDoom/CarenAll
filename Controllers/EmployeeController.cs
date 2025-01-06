using CarenAll.data;
using CarenAll.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarenAll.Controllers
{
    [Route("employee")]
    [ApiController]

    public class EmployeeController : Controller
    {
        private readonly LoginDbContext _loginDbContext;
        private readonly AppDbContext _appDbContext;

        public EmployeeController(LoginDbContext loginDbContext, AppDbContext appDbContext)
        {
            _loginDbContext = loginDbContext;
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            return View("employeeview");
        }
    }


}