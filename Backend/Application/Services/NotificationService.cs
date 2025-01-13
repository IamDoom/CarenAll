namespace CarAndAll.Application.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    // NotificationService for sending email notifications
    public class NotificationService
    {
        private readonly List<string> _notifications;

        public NotificationService()
        {
            _notifications = new List<string>();
        }

        public Task<string> SendEmailNotificationAsync(string recipientEmail, string subject, string message)
        {
            if (string.IsNullOrWhiteSpace(recipientEmail) || string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(message))
            {
                return Task.FromResult("Invalid notification details.");
            }

            var notification = $"To: {recipientEmail}\nSubject: {subject}\nMessage: {message}";
            _notifications.Add(notification);

            Console.WriteLine($"Notification sent to {recipientEmail}");

            return Task.FromResult("Notification sent successfully.");
        }

        public Task<List<string>> GetAllNotificationsAsync()
        {
            return Task.FromResult(_notifications);
        }

        public Task<string> SendRentalReminderAsync(string recipientEmail, string vehicleDetails, DateTime rentalStartDate)
        {
            var subject = "Rental Reminder: Upcoming Vehicle Pickup";
            var message = $"Dear customer,\n\nThis is a reminder that your rental vehicle ({vehicleDetails}) will be ready for pickup on {rentalStartDate:dddd, MMMM d, yyyy}.\nPlease ensure you bring the necessary documents.\n\nThank you for choosing CarAndAll!";

            return SendEmailNotificationAsync(recipientEmail, subject, message);
        }
    }
}
