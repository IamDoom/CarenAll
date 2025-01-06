using CarenAll.data;
using CarenAll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore.Query;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http.Metadata;
using System.Reflection.Metadata.Ecma335;

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
            var credentials = await _loginDbContext.Credentials
                .FirstOrDefaultAsync(c => c.Username == CredDto.Username);

            if (credentials == null)
            {
                
                ModelState.AddModelError("", "Invalid username or password.");
                return View("login"); //i need to add login errors.
            }
            if (!PasswordCheck(CredDto.PasswordHash, credentials.PasswordHash))
            {
                
                ModelState.AddModelError("", "Invalid username or password.");
                return View("login");
            }
            //who reads these anyway, i am so tired ugh.

            var user = await _appDbContext.Users
                .FirstOrDefaultAsync(u => u.Id == credentials.Id);

            if (user == null)
            {
                ModelState.AddModelError("", "An error occurred during login.");
                return View("login");
            }
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View("login");
        }

        
        /* public async Task<IActionResult> ParticulierPreRegistration([FromBody] PrivateClient RegisterDto)
        {
            if (await _loginDbContext.Credentials.AnyAsync(c => c.Username == RegisterDto.Email))
            {
                return BadRequest("Username already exists.");
            }

            if (await _appDbContext.Users.AnyAsync(u => u.Email == RegisterDto.Email))
            {
                return BadRequest("Email already exists.");
            }

            if (await _appDbContext.PrivateClients.AnyAsync(u => u.PhoneNumber == RegisterDto.PhoneNumber))
            {
                return BadRequest("Phone number already exists.");
            }

            return Ok("Pre-registration checks passed.");
        } */

        [HttpPost("register")] 
        public async Task<IActionResult> RegisterPrivateClient(string username, string password, string email, string phonenumber) //deze functie is veroudert en moet bijgewerkt worden.
        {
            if (await _loginDbContext.Credentials.AnyAsync(c => c.Username == username))
            {
                ModelState.AddModelError("", "Username already exists.");
                return View("login");
            }
            if (await _appDbContext.PrivateClients.AnyAsync(u => u.Email == email))
            {
                ModelState.AddModelError("", "this email already exists");
                return View("login");
            }
            var userId = Guid.NewGuid();

            var salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var hashedPassword = KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8);

            var passwordHash = Convert.ToBase64String(salt.Concat(hashedPassword).ToArray());

            var user = new PrivateClient
            {
                Id = userId.GetHashCode(),
                Email = email,
                PhoneNumber = phonenumber,
                FirstName = "FirstName",
                LastName = "LastName"
            };
            var credentials = new Credentials(user.Id, username, passwordHash);

            // opslaan in de db
            await _appDbContext.Users.AddAsync(user);
            await _loginDbContext.Credentials.AddAsync(credentials);

            await _appDbContext.SaveChangesAsync();
            await _loginDbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");

        }
        //functie gegenereert door chatgpt
        private bool PasswordCheck(string input, string saved) 
        {
            var hashBytes = Convert.FromBase64String(saved);
            var salt = hashBytes.Take(16).ToArray();

            // Generate the hash for the provided password using the same salt
            var hash = KeyDerivation.Pbkdf2(
                password: input,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8);

            // Compare the computed hash with the stored hash
            return hashBytes.SequenceEqual(hash);
        }

        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok("LoginController is working!");
        }

    }


}
