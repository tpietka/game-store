using UserManagement.ViewModels;

namespace UserManagement.Services;

public interface IUserSignUpService
{
    void SignUp(UserSignUpVm userSignUp);
}