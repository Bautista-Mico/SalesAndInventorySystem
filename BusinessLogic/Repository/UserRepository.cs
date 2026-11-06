using Model;

namespace BusinessLogic.Repository;

internal class StoredUser
{
    public User User { get; set; } = new();
    public string PasswordHash { get; set; } = "";
}

// In-memory version: data lives only while the app is running.
public class UserRepository
{
    internal static readonly List<StoredUser> Store = new();
    internal static readonly object Sync = new();
    private static int _nextId = 1;

    public UserRepository(string connectionString = "") { }

    public int Add(User user, string passwordHash)
    {
        lock (Sync)
        {
            if (Store.Any(s => s.User.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Username already exists.");

            var copy = Clone(user);
            copy.UserId = _nextId++;
            copy.CreatedAt = DateTime.Now;
            Store.Add(new StoredUser { User = copy, PasswordHash = passwordHash });
            return copy.UserId;
        }
    }

    public List<User> Search(string keyword = "")
    {
        lock (Sync)
        {
            keyword ??= "";
            return Store
                .Where(s => s.User.Username.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                         || s.User.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .OrderBy(s => s.User.UserId)
                .Select(s => Clone(s.User))
                .ToList();
        }
    }

    public bool Update(User user, string? newPasswordHash = null)
    {
        lock (Sync)
        {
            var existing = Store.FirstOrDefault(s => s.User.UserId == user.UserId);
            if (existing == null) return false;

            if (Store.Any(s => s.User.UserId != user.UserId &&
                               s.User.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Username already exists.");

            existing.User.Username = user.Username;
            existing.User.FullName = user.FullName;
            existing.User.Role = user.Role;
            existing.User.IsActive = user.IsActive;
            if (newPasswordHash != null) existing.PasswordHash = newPasswordHash;
            return true;
        }
    }

    public bool Unlock(int userId)
    {
        lock (Sync)
        {
            var existing = Store.FirstOrDefault(s => s.User.UserId == userId);
            if (existing == null) return false;
            existing.User.IsLocked = false;
            existing.User.FailedLoginAttempts = 0;
            return true;
        }
    }

    public bool Delete(int userId)
    {
        lock (Sync) return Store.RemoveAll(s => s.User.UserId == userId) > 0;
    }

    private static User Clone(User u) => new()
    {
        UserId = u.UserId,
        Username = u.Username,
        FullName = u.FullName,
        Role = u.Role,
        IsActive = u.IsActive,
        FailedLoginAttempts = u.FailedLoginAttempts,
        IsLocked = u.IsLocked,
        CreatedAt = u.CreatedAt
    };
}