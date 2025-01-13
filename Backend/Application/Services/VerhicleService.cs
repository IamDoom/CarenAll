namespace CarAndAll.Application.Services
{
    using CarAndAll.Core.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    // VehicleService for handling vehicle operations
    public class VehicleService
    {
        private readonly List<Vehicle> _vehicles;

        public VehicleService()
        {
            _vehicles = new List<Vehicle>();
        }

        public Task AddVehicleAsync(string brand, string model, string licensePlate, string color, DateTime yearOfPurchase, VehicleType type)
        {
            var vehicle = new Vehicle(brand, model, licensePlate, color, yearOfPurchase, type);
            _vehicles.Add(vehicle);
            return Task.CompletedTask;
        }

        public Task<Vehicle?> GetVehicleByIdAsync(Guid id)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
            return Task.FromResult(vehicle);
        }

        public Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            return Task.FromResult(_vehicles);
        }

        public Task UpdateVehicleAvailabilityAsync(Guid id, bool isAvailable)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
            if (vehicle != null)
            {
                if (isAvailable)
                {
                    vehicle.MarkAsAvailable();
                }
                else
                {
                    vehicle.MarkAsUnavailable();
                }
            }
            return Task.CompletedTask;
        }

        public Task RemoveVehicleAsync(Guid id)
        {
            _vehicles.RemoveAll(v => v.Id == id);
            return Task.CompletedTask;
        }

        public Task<List<Vehicle>> GetAvailableVehiclesAsync()
        {
            var availableVehicles = _vehicles.Where(v => v.IsAvailable).ToList();
            return Task.FromResult(availableVehicles);
        }

        public Task<List<Vehicle>> GetVehiclesByTypeAsync(VehicleType type)
        {
            var vehiclesByType = _vehicles.Where(v => v.Type == type).ToList();
            return Task.FromResult(vehiclesByType);
        }
    }
}
