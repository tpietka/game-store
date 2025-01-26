using UserManagement.Entities;
using UserManagement.Exceptions;
using UserManagement.Repositories;
using UserManagement.ViewModels;

namespace UserManagement.Services;
public class UserSignUpService : IUserSignUpService
{
    private readonly IUserSaveRepository _userSaveRepository;
    private readonly IUserReadRepository _userReadRepository;
    public UserSignUpService(IUserReadRepository readRepository, IUserSaveRepository saveRepository)
    {
        _userReadRepository = readRepository ?? throw new ArgumentNullException(nameof(readRepository));
        _userSaveRepository = saveRepository ?? throw new ArgumentNullException(nameof(saveRepository));
    } 

    public void SignUp(UserSignUpVm userSignUp)
    {
        var emailExists = _userReadRepository.DoesEmailExist(userSignUp.Email);
        if(emailExists)
        {
            throw new EmailAlreadyExistsException();
        }

        _userSaveRepository.Save(userSignUp);
    }
}
