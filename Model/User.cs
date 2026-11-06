using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Role { get; set; } = "Staff";   // Admin / Manager / Staff
        public bool IsActive { get; set; } = true;
        public int FailedLoginAttempts { get; set; }
        public bool IsLocked { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
