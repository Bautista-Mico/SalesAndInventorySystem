namespace SalesInventory.Model;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
    public bool IsActive { get; set; } = true;
    public int FailedAttempts { get; set; }
    public bool IsLocked { get; set; }
    public DateTime? LockoutEnd { get; set; }
    public DateTime? LastLoginAt { get; set; }

    public string RoleDisplay => Roles.Display(Role);
    public string StatusText => IsActive ? "Active" : "Disabled";
    public override string ToString() => FullName;
}
