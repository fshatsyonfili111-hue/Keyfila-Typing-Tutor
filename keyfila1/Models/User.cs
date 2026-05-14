using System;

namespace keyfila1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Note: In production, store hashes only
        public DateTime CreatedAt { get; set; }
    }
}
