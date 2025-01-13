using Microsoft.AspNetCore.Mvc;
using CarAndAll.Application.Services;
using CarAndAll.Core.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CarAndAll.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController : ControllerBase
    {
        private readonly SubscriptionService _subscriptionService;

        public SubscriptionController(SubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateSubscription(string type, decimal cost, DateTime startDate)
        {
            if (string.IsNullOrWhiteSpace(type) || cost <= 0)
            {
                return BadRequest("Invalid subscription details.");
            }

            var result = await _subscriptionService.CreateSubscriptionAsync(type, cost, startDate);
            return Ok(result);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetSubscription(Guid id)
        {
            var subscription = await _subscriptionService.GetSubscriptionByIdAsync(id);
            if (subscription == null)
            {
                return NotFound("Subscription not found.");
            }

            return Ok(subscription);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllSubscriptions()
        {
            var subscriptions = await _subscriptionService.GetAllSubscriptionsAsync();
            return Ok(subscriptions);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateSubscription(Guid id, string newType, decimal newCost)
        {
            if (string.IsNullOrWhiteSpace(newType) || newCost <= 0)
            {
                return BadRequest("Invalid subscription details.");
            }

            var result = await _subscriptionService.UpdateSubscriptionAsync(id, newType, newCost);
            if (result != "Subscription updated successfully.")
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        [HttpPut("End/{id}")]
        public async Task<IActionResult> EndSubscription(Guid id, DateTime endDate)
        {
            var result = await _subscriptionService.EndSubscriptionAsync(id, endDate);
            if (result != "Subscription ended successfully.")
            {
                return NotFound(result);
            }

            return Ok(result);
        }
    }
}
