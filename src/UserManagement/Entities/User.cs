using UserManagement.ValueObjects;

namespace UserManagement.Entities;
public class User
{
    internal UserId Id { get; set; }
    internal Email Email { get; set; }
    internal UserName UserName { get; set; }
    internal EmailVerificationStatus EmailVerificationStatus { get; set; }

}
