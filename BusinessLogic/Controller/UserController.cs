using System.Security.Cryptography;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller;

public class UserController
{
    private static readonly string[] ValidRoles = { "Admin", "Manager", "Staff" };
    private readonly UserRepository _repo;

    public UserController(UserRepository repo) => _repo = repo;

    public List<User> GetAll() => _repo.Search("");

    public List<User> Search(string keyword) => _repo.Search(keyword.Trim());

    public int Create(User user, string password)
    {
        Validate(user);
        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            throw new ArgumentException("Password must be at least 6 characters.");
        return _repo.Add(user, HashPassword(password));
    }

    public void Update(User user, string? newPassword)
    {
        Validate(user);
        string? hash = null;
        if (!string.IsNullOrWhiteSpace(newPassword))
        {
            if (newPassword.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters.");
            hash = HashPassword(newPassword);
        }
        if (!_repo.Update(user, hash))
            throw new InvalidOperationException("User not found.");
    }

    // Only a System Administrator can unlock a locked account.
    public void Unlock(int userId, User actingUser)
    {
        if (actingUser.Role != "Admin")
            throw new UnauthorizedAccessException("Only a System Administrator can unlock accounts.");
        if (!_repo.Unlock(userId))
            throw new InvalidOperationException("User not found.");
    }

    public void Delete(int userId)
    {
        if (!_repo.Delete(userId))
            throw new InvalidOperationException("User not found.");
    }

    private static void Validate(User u)
    {
        if (string.IsNullOrWhiteSpace(u.Username)) throw new ArgumentException("Username is required.");
        if (string.IsNullOrWhiteSpace(u.FullName)) throw new ArgumentException("Full name is required.");
        if (!ValidRoles.Contains(u.Role)) throw new ArgumentException("Invalid role.");
    }

    // PBKDF2, stored as "salt:hash" (Base64)
    public static string HashPassword(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);
        return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
    }

    public static bool VerifyPassword(string password, string stored)
    {
        var parts = stored.Split(':');
        byte[] salt = Convert.FromBase64String(parts[0]);
        byte[] expected = Convert.FromBase64String(parts[1]);
        byte[] actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);
        return CryptographicOperations.FixedTimeEquals(actual, expected);
    }
}