﻿using CarenAll.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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
            var vehicles = await _appDbContext.Vehicles
                .Select(e => new
                {
                    e.Id,
                    e.Merk,
                    e.Type,
                    e.Kenteken,
                    e.Kleur
                })
                .ToListAsync(); // Gebruik ToListAsync voor asynchrone query

            return Json(vehicles);
        }
    }
}
