using CarenAll.data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarenAll.Controllers
{
    public class CarController : Controller
    {
        private readonly LoginDbContext _loginDbContext;
        private readonly AppDbContext _appDbContext;

        public CarController(LoginDbContext loginDbContext, AppDbContext appDbContext)
        {
            _loginDbContext = loginDbContext;
            _appDbContext = appDbContext;

        }
        [HttpGet("GetAllVehicles")]
        public async Task<IActionResult> GetAllVehicles()
        {
            var vehicles = _appDbContext.Vehicles
                .Select(e => new
                {
                    e.Id,
                    e.Merk,
                    e.Type,
                    e.Kenteken,
                    e.Kleur
                })
                .ToList();
            return Json(vehicles);
        }
        [HttpPost("selectVehicleType")]
        public IActionResult SelectType()
        {
            if (string.IsNullOrEmpty(request.Type))
                return BadRequest("Vehicle type is required.");

            // Return mock data or fetch available vehicle models from the database
            var availableVehicles = new List<object>
            {
                new { Id = 1, Model = "Sedan A", Type = request.Type },
                new { Id = 2, Model = "Sedan B", Type = request.Type }
            };

            return Ok(availableVehicles);
        }
    }
}
