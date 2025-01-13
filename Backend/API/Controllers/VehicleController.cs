using Microsoft.AspNetCore.Mvc;
using CarAndAll.Application.Services;
using CarAndAll.Core.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CarAndAll.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _vehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost("AddVehicle")]
        public async Task<IActionResult> AddVehicle([FromBody] Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest("Invalid vehicle data.");
            }

            await _vehicleService.AddVehicleAsync(vehicle.Brand, vehicle.Model, vehicle.LicensePlate, vehicle.Color, vehicle.YearOfPurchase);
            return Ok("Vehicle added successfully.");
        }

        [HttpGet("GetVehicle/{id}")]
        public async Task<IActionResult> GetVehicle(Guid id)
        {
            var vehicle = await _vehicleService.GetVehicleByIdAsync(id);
            if (vehicle == null)
            {
                return NotFound("Vehicle not found.");
            }

            return Ok(vehicle);
        }

        [HttpGet("GetAllVehicles")]
        public async Task<IActionResult> GetAllVehicles()
        {
            var vehicles = await _vehicleService.GetAllVehiclesAsync();
            return Ok(vehicles);
        }

        [HttpPut("UpdateAvailability/{id}")]
        public async Task<IActionResult> UpdateAvailability(Guid id, [FromBody] bool isAvailable)
        {
            var result = await _vehicleService.UpdateVehicleAvailabilityAsync(id, isAvailable);
            if (!result)
            {
                return NotFound("Vehicle not found.");
            }

            return Ok("Vehicle availability updated successfully.");
        }

        [HttpDelete("RemoveVehicle/{id}")]
        public async Task<IActionResult> RemoveVehicle(Guid id)
        {
            var result = await _vehicleService.RemoveVehicleAsync(id);
            if (!result)
            {
                return NotFound("Vehicle not found.");
            }

            return Ok("Vehicle removed successfully.");
        }
    }
}
