using UserManagement.ValueObjects;

namespace UserManagement.Entities;
internal class UserLogin
{
    public Email Email { get; set; }
    public string Password { get; set; }
}
