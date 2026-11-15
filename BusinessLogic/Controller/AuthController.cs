using SalesInventory.BusinessLogic.Repository;
using SalesInventory.Model;

namespace SalesInventory.BusinessLogic.Controller;

public class AuthController
{
    public const int MaxFailedAttempts = 5;
    public const int LockoutMinutes = 15;
    public const int SessionTimeoutMinutes = 15;

    public User Login(string login, string password)
    {
        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(password))
            throw new BusinessRuleException("Username and password are both required.");
        if (password.Length < 8)
            throw new BusinessRuleException("Password must be at least 8 characters.");

        var user = UserRepository.GetByLogin(login.Trim());
        if (user == null) throw new BusinessRuleException("Invalid username or password.");
        if (!user.IsActive) throw new BusinessRuleException("This account is disabled. Please contact your administrator.");
        if (user.IsLocked)
            throw new BusinessRuleException($"This account is temporarily locked until {user.LockoutEnd:h:mm tt}. Please try again later.");

        if (!PasswordHasher.Verify(password, user.PasswordHash))
        {
            var (attempts, locked) = UserRepository.RecordFailed(user.UserId, MaxFailedAttempts, LockoutMinutes);
            UserRepository.Audit(user.UserId, "LoginFailed", "Invalid password");
            if (locked)
                throw new BusinessRuleException($"Too many failed attempts. The account is locked for {LockoutMinutes} minutes.");
            throw new BusinessRuleException($"Invalid username or password. {MaxFailedAttempts - attempts} attempt(s) remaining.");
        }

        UserRepository.RecordSuccess(user.UserId);
        UserRepository.Audit(user.UserId, "Login", "Signed in");
        user.PasswordHash = null;
        Session.Current = user;
        return user;
    }

    public void Logout(string reason = "Logout")
    {
        if (Session.Current != null) UserRepository.Audit(Session.Current.UserId, reason, "Signed out");
        Session.Current = null;
    }

    /// <summary>Checks a second person's credentials (supervisor / admin override). Does not change the session.</summary>
    public User Authorize(string username, string password, params string[] allowedRoles)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            throw new BusinessRuleException("Enter the approver's username and password.");
        var u = UserRepository.GetByLogin(username.Trim());
        if (u == null || !u.IsActive || u.IsLocked || !PasswordHasher.Verify(password, u.PasswordHash))
            throw new BusinessRuleException("Authorization failed: invalid credentials.");
        if (allowedRoles.Length > 0 && !allowedRoles.Contains(u.Role))
            throw new BusinessRuleException("Authorization failed: this account does not have the required role.");
        UserRepository.Audit(u.UserId, "Authorized", "Secondary authorization granted");
        u.PasswordHash = null;
        return u;
    }

    /// <summary>Re-asks the signed-in user for their password (e.g. before a duplicate receipt reprint).</summary>
    public void VerifyCurrentPassword(string password)
    {
        var u = UserRepository.GetByLogin(Session.Current.Username);
        if (u == null || !PasswordHasher.Verify(password ?? "", u.PasswordHash))
            throw new BusinessRuleException("Incorrect password.");
    }
}
