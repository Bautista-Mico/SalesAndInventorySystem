using SalesInventory.BusinessLogic.Repository;
using SalesInventory.Model;
using System.Text.RegularExpressions;

namespace SalesInventory.BusinessLogic.Controller;

public class UserController
{
    public List<User> List(string search) => UserRepository.GetAll(search);

    public int Save(User u, string newPassword)
    {
        if (!Permissions.CanManageUsers) throw new BusinessRuleException("Only administrators can manage users.");
        if (string.IsNullOrWhiteSpace(u.Username)) throw new BusinessRuleException("Username is required.");
        if (string.IsNullOrWhiteSpace(u.FullName)) throw new BusinessRuleException("Full name is required.");
        if (!Regex.IsMatch(u.Email ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) throw new BusinessRuleException("Enter a valid email address.");
        if (!Roles.All.Contains(u.Role)) throw new BusinessRuleException("Choose a role.");
        if (u.UserId == 0 && string.IsNullOrEmpty(newPassword)) throw new BusinessRuleException("A password is required for a new user.");
        if (!string.IsNullOrEmpty(newPassword) && newPassword.Length < 8) throw new BusinessRuleException("Password must be at least 8 characters.");
        return UserRepository.Save(u, string.IsNullOrEmpty(newPassword) ? null : PasswordHasher.Hash(newPassword));
    }

    public void ResetPassword(User u, string newPassword)
    {
        if (!Permissions.CanManageUsers) throw new BusinessRuleException("Only administrators can manage users.");
        if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 8) throw new BusinessRuleException("Password must be at least 8 characters.");
        UserRepository.SetPassword(u.UserId, PasswordHasher.Hash(newPassword));
    }

    public void SetActive(User u, bool active)
    {
        if (u.UserId == Session.Current.UserId && !active) throw new BusinessRuleException("You cannot disable your own account.");
        u.IsActive = active;
        UserRepository.Save(u, null);
    }
}
