﻿namespace CarenAll.Models
{
    public class TemporaryUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public DateTime CreatedAt { get; set; }

    }
}