using System.ComponentModel.DataAnnotations;
using UserManagement.ValueObjects;

namespace UserManagement.Entities;
internal class UserSignUp
{
    public Email Email { get; set; }
    public string Password { get; set; }
}
