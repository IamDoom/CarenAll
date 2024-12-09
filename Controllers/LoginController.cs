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

namespace CarenAll.Controllers
{
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
        public async Task<IActionResult> Login(string username, string password)
        {
            var credentials = await _loginDbContext.Credentials
                .FirstOrDefaultAsync(c => c.Username == username);
            if (credentials == null)
            {
                
                ModelState.AddModelError("", "Invalid username or password.");
                return View("login"); //i need to add login errors.
            }
            if (!PasswordCheck(password, credentials.PasswordHash))
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
    }
}
