namespace CarAndAll.Application.Services
{
    using CarAndAll.Core.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    // SubscriptionService for managing subscriptions
    public class SubscriptionService
    {
        private readonly List<Subscription> _subscriptions;

        public SubscriptionService()
        {
            _subscriptions = new List<Subscription>();
        }

        public Task<string> CreateSubscriptionAsync(string type, decimal cost, DateTime startDate)
        {
            var subscription = new Subscription(type, cost, startDate);
            _subscriptions.Add(subscription);
            return Task.FromResult("Subscription created successfully.");
        }

        public Task<Subscription?> GetSubscriptionByIdAsync(Guid id)
        {
            var subscription = _subscriptions.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(subscription);
        }

        public Task<List<Subscription>> GetAllSubscriptionsAsync()
        {
            return Task.FromResult(_subscriptions);
        }

        public Task<string> UpdateSubscriptionAsync(Guid id, string newType, decimal newCost)
        {
            var subscription = _subscriptions.FirstOrDefault(s => s.Id == id);
            if (subscription == null)
            {
                return Task.FromResult("Subscription not found.");
            }

            subscription = new Subscription(newType, newCost, subscription.StartDate);
            return Task.FromResult("Subscription updated successfully.");
        }

        public Task<string> EndSubscriptionAsync(Guid id, DateTime endDate)
        {
            var subscription = _subscriptions.FirstOrDefault(s => s.Id == id);
            if (subscription == null)
            {
                return Task.FromResult("Subscription not found.");
            }

            subscription.EndSubscription(endDate);
            return Task.FromResult("Subscription ended successfully.");
        }
    }
}
