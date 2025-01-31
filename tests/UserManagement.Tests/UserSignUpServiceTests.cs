using UserManagement.Exceptions;
using UserManagement.Services;
using UserManagement.Tests.Stubs;
using UserManagement.ViewModels;

namespace UserManagement.Tests;

public class UserSignUpServiceTests
{
    [Fact]
    public void NewSignUpUser_DoesNotThrowException()
    {
        //Arrange
        var userRepository = new UserRepositoryStub();
        var signUpService = new UserSignUpService(userRepository, userRepository);
        var userService = new UserService(userRepository);

        var userToSave = new UserSignUpVm
        {
            Email = "example@domain.com",
            Password = "1",
            ConfirmPassword = "1"
        };

        //Act
        signUpService.SignUp(userToSave);
        var user = userService.GetByEmail("example@domain.com");

        //Assert
        Assert.Same(user.Email.email, userToSave.Email);
    }

    [Fact]
    public void NewSignUpUser_DoesThrowException()
    {
        //Arrange
        var userRepository = new UserRepositoryStub();
        var signUpService = new UserSignUpService(userRepository, userRepository);
        var userService = new UserService(userRepository);

        var userToSave = new UserSignUpVm
        {
            Email = "example@domain.com",
            Password = "1",
            ConfirmPassword = "1"
        };

        //Act
        signUpService.SignUp(userToSave);
        Assert.Throws<EmailAlreadyExistsException>(() => signUpService.SignUp(userToSave));
    }
}