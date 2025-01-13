using Microsoft.AspNetCore.Mvc;
using CarAndAll.Application.Services;
using CarAndAll.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAndAll.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(string name, string email, string password, bool isCorporate)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("Invalid registration details.");
            }

            var existingCustomer = await _userService.GetCustomerByEmailAsync(email);
            if (existingCustomer != null)
            {
                return Conflict("Email is already registered.");
            }

            await _userService.RegisterCustomerAsync(name, email, password, isCorporate);
            return Ok("Customer registered successfully.");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("Invalid login details.");
            }

            var customer = await _userService.AuthenticateCustomerAsync(email, password);
            if (customer == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            return Ok("Login successful.");
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(string name, string email, string password, bool isCorporate)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("Invalid customer data.");
            }

            await _userService.RegisterCustomerAsync(name, email, password, isCorporate);
            return Ok("Customer added successfully.");
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(string name, string email, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                return BadRequest("Invalid employee data.");
            }

            await _userService.RegisterEmployeeAsync(name, email, password, role);
            return Ok("Employee added successfully.");
        }

        [HttpGet("GetCustomer/{id}")]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            var customer = await _userService.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound("Customer not found.");
            }

            return Ok(customer);
        }

        [HttpGet("GetEmployee/{id}")]
        public async Task<IActionResult> GetEmployee(Guid id)
        {
            var employee = await _userService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(employee);
        }

        [HttpDelete("RemoveCustomer/{id}")]
        public async Task<IActionResult> RemoveCustomer(Guid id)
        {
            await _userService.RemoveCustomerAsync(id);
            return Ok("Customer removed successfully.");
        }

        [HttpDelete("RemoveEmployee/{id}")]
        public async Task<IActionResult> RemoveEmployee(Guid id)
        {
            await _userService.RemoveEmployeeAsync(id);
            return Ok("Employee removed successfully.");
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _userService.GetAllCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _userService.GetAllEmployeesAsync();
            return Ok(employees);
        }
    }
}
