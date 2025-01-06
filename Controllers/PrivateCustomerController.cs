using Microsoft.AspNetCore.Mvc;
using CarenAll.data;
using CarenAll.Models;
using System.Diagnostics;

namespace CarenAll.Controllers
{
    [Route("Privatecustomer")]
    [ApiController]

    public class PrivateCustomerController : Controller
    {
        private readonly LoginDbContext _loginDbContext;
        private readonly AppDbContext _appDbContext;

        public PrivateCustomerController(LoginDbContext loginDbContext, AppDbContext appDbContext)
        {
            _loginDbContext = loginDbContext;
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            return View("privatecustomer");
        }
    }


}
