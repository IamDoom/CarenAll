using CarenAll.data;
using CarenAll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CarenAll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {

        private readonly LoginDbContext _loginDbContext;
        private readonly AppDbContext _appDbContext;

        public LoginController(LoginDbContext loginDbContext, AppDbContext appDbContext)
        {
            _loginDbContext = loginDbContext;
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Credentials CredDto)
        {
            Console.WriteLine($"Username: {CredDto.Username}, Password: {CredDto.PasswordHash}");
            var credentials = await _loginDbContext.Credentials
                .FirstOrDefaultAsync(c => c.Username == CredDto.Username);

            if (credentials == null || credentials.PasswordHash != CredDto.PasswordHash)
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return BadRequest();
            }

            var user = await _appDbContext.Users
                .FirstOrDefaultAsync(u => u.Id == credentials.RefID);

            if (user == null)
            {
                ModelState.AddModelError("", "An error occurred during login.");
                return BadRequest();
            }

            HttpContext.Session.SetString("userType", user.GetType().ToString());
            HttpContext.Session.SetInt32("userID", user.Id);
            return Ok("/privatecustomer");
        }

        public IActionResult Index()
        {
            return View("login");
        }

[HttpPost("ParticulierRegistration")]
public async Task<IActionResult> RegisterPrivateClient([FromBody] PrivateClientDto dto)
{
    if (await _loginDbContext.Credentials.AnyAsync(c => c.Username == dto.Username))
    {
        return BadRequest(new { message = "Username already exists." });
    }
    if (await _appDbContext.Users.AnyAsync(u => u.Email == dto.Email))
    {
        return BadRequest(new { message = "Email already exists." });
    }
    if (await _appDbContext.PrivateClients.AnyAsync(u => u.PhoneNumber == dto.PhoneNumber))
    {
        return BadRequest(new { message = "Phone number already exists." });
    }

    var user = new PrivateClient
    {
        Email = dto.Email,
        PhoneNumber = dto.PhoneNumber,
        FirstName = dto.firstname,
        LastName = dto.lastname
    };

    await _appDbContext.Users.AddAsync(user);
    await _appDbContext.SaveChangesAsync();

    var hashedPassword = dto.Password; //hash later
    var credentials = new Credentials(dto.Username, hashedPassword);
            credentials.RefID = user.Id;
           

    await _loginDbContext.Credentials.AddAsync(credentials);
    await _loginDbContext.SaveChangesAsync();

    return Ok(new { message = "Registration successful!" });
}

        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok("LoginController is working!");
        }

    }
}
