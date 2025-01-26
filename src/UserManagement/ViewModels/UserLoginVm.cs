using System.ComponentModel.DataAnnotations;

namespace UserManagement.ViewModels;

public class UserLoginVm
{
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(8), MaxLength(30)]
    public string Password { get; set; }
}
