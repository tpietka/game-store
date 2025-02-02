using System.ComponentModel.DataAnnotations;

namespace UserManagement.ViewModels;
public class UserSignUpVm
{
    private const string PASSWORD_DOES_NOT_MATCH = "Passwords do not match.";

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(8), MaxLength(30)]
    public string Password { get; set; }
    [Required]
    [MinLength(8), MaxLength(30)]
    [Compare(nameof(Password), ErrorMessage = PASSWORD_DOES_NOT_MATCH)]
    public string ConfirmPassword { get; set; }
}
