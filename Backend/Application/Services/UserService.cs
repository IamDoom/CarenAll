namespace CarAndAll.Application.Services
{
    using CarAndAll.Core.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    // UserService for handling Customers and Employees, including corporate account restrictions
    public class UserService
    {
        private readonly List<Customer> _customers;
        private readonly List<Employee> _employees;

        public UserService()
        {
            _customers = new List<Customer>();
            _employees = new List<Employee>();
        }

        public Task RegisterCorporateCustomerAsync(string companyName, string name, string email, string password)
        {
            var customer = new Customer(name, email, password, true, CustomerRole.FleetManager)
            {
                CompanyName = companyName
            };
            _customers.Add(customer);
            return Task.CompletedTask;
        }

        public Task RegisterCorporateEmployeeAsync(Guid fleetManagerId, string name, string email, string password)
        {
            var fleetManager = _customers.FirstOrDefault(c => c.Id == fleetManagerId && c.Role == CustomerRole.FleetManager);
            if (fleetManager == null)
            {
                throw new Exception("Fleet Manager not found.");
            }

            var employee = new Employee(name, email, password, EmployeeRole.CorporateRenter, fleetManager.Id);
            _employees.Add(employee);
            return Task.CompletedTask;
        }

        public Task<bool> CanCorporateRenterRentVehicleAsync(Guid employeeId, VehicleType vehicleType)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == employeeId && e.Role == EmployeeRole.CorporateRenter);
            if (employee == null)
            {
                throw new Exception("Employee not found or not a corporate renter.");
            }

            return Task.FromResult(vehicleType == VehicleType.Car);
        }

        public Task<List<Employee>> GetCorporateEmployeesAsync(Guid fleetManagerId)
        {
            var employees = _employees.Where(e => e.CompanyId == fleetManagerId).ToList();
            return Task.FromResult(employees);
        }

        public Task<string> ApproveCorporateRentalRequestAsync(Guid rentalId, Guid employeeId)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == employeeId && e.Role == EmployeeRole.BackOffice);
            if (employee == null)
            {
                return Task.FromResult("Access denied. Only BackOffice employees can approve corporate rental requests.");
            }

            return Task.FromResult("Corporate rental request approved.");
        }
    }
}
