using BusinessLogic.Repository;

namespace BusinessLogic.Controller;

public class LoginResult
{
    public bool Success { get; set; }
    public bool IsLocked { get; set; }
    public string Message { get; set; } = "";
    public string Role { get; set; } = "";
}

public class LoginController
{
    public const int MaxAttempts = 5;
    private const string LockedMessage = "Account locked due to 5 failed attempts. Contact a System Administrator.";

    private readonly LoginRepository _repo;

    public LoginController(LoginRepository repo) => _repo = repo;

    public LoginResult Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            return Fail("Enter your username and password.");

        var rec = _repo.GetForLogin(username.Trim());

        // Same message for unknown users so usernames can't be guessed.
        if (rec == null)
            return Fail("Invalid username or password.");

        if (rec.IsLocked)
            return new LoginResult { IsLocked = true, Message = LockedMessage };

        if (!rec.IsActive)
            return Fail("This account is inactive.");

        bool passwordOk = UserController.VerifyPassword(password, rec.PasswordHash);
        var (attempts, locked) = _repo.RecordAttempt(rec.Username, passwordOk);

        if (passwordOk)
            return new LoginResult { Success = true, Message = "Login successful.", Role = rec.Role };

        if (locked)
            return new LoginResult { IsLocked = true, Message = LockedMessage };

        int remaining = Math.Max(0, MaxAttempts - attempts);
        return Fail($"Invalid username or password. {remaining} attempt(s) remaining.");
    }

    private static LoginResult Fail(string message) => new() { Message = message };
}
