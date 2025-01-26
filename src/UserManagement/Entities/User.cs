namespace UserManagement.Entities;

public class User
{
    public UserId Id { get; set; }
    public Email Email { get; set; }
    public PasswordHash PasswordHash { get; set; }
    public EmailVerificationStatus EmailVerificationStatus { get; set; }

}
