using Microsoft.AspNetCore.Mvc;
using CarenAll.data;
using CarenAll.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

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
        [HttpGet("getprivateinfo")]
        public async Task<IActionResult> GetUserInfo()
        {
            var userID = HttpContext.Session.GetInt32("userID");
            if (userID == null)
            {
                return Unauthorized(new {message = "user not logged in"});
            }

            var data = await _appDbContext.PrivateClients
                .Where(u => u.Id == userID)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber
                })
                .FirstOrDefaultAsync();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        public IActionResult Index()
        {
            return View("privatecustomer");
        }
    }


}
