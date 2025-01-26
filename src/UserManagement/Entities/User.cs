namespace UserManagement.Entities;
public class User
{
    internal UserId Id { get; set; }
    internal Email Email { get; set; }
    internal PasswordHash PasswordHash { get; set; }
    internal EmailVerificationStatus EmailVerificationStatus { get; set; }

}
