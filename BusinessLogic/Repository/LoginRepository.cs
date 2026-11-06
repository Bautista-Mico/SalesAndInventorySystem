namespace BusinessLogic.Repository;

public class LoginRecord
{
    public int UserId { get; set; }
    public string Username { get; set; } = "";
    public string FullName { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Role { get; set; } = "";
    public bool IsActive { get; set; }
    public bool IsLocked { get; set; }
    public int FailedLoginAttempts { get; set; }
}

public class LoginRepository
{
    private const int MaxAttempts = 5;

    public LoginRepository(string connectionString = "") { }

    public LoginRecord? GetForLogin(string username)
    {
        lock (UserRepository.Sync)
        {
            var s = Find(username);
            if (s == null) return null;
            return new LoginRecord
            {
                UserId = s.User.UserId,
                Username = s.User.Username,
                FullName = s.User.FullName,
                PasswordHash = s.PasswordHash,
                Role = s.User.Role,
                IsActive = s.User.IsActive,
                IsLocked = s.User.IsLocked,
                FailedLoginAttempts = s.User.FailedLoginAttempts
            };
        }
    }

    // Updates the failure counter, locks at 5, resets on success.
    public (int Attempts, bool IsLocked) RecordAttempt(string username, bool success)
    {
        lock (UserRepository.Sync)
        {
            var s = Find(username);
            if (s == null) return (0, false);
            if (s.User.IsLocked) return (s.User.FailedLoginAttempts, true);

            if (success)
            {
                s.User.FailedLoginAttempts = 0;
            }
            else
            {
                s.User.FailedLoginAttempts++;
                if (s.User.FailedLoginAttempts >= MaxAttempts) s.User.IsLocked = true;
            }
            return (s.User.FailedLoginAttempts, s.User.IsLocked);
        }
    }

    private static StoredUser? Find(string username) =>
        UserRepository.Store.FirstOrDefault(x =>
            x.User.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
}
