using UserManagement.Dto;
using UserManagement.Entities;
using UserManagement.Repositories;
using UserManagement.ViewModels;

namespace UserManagement.Tests.Stubs;
internal class UserRepositoryStub : IUserReadRepository, IUserSaveRepository
{
    private List<UserSignUpVm> _users = new();

    public bool DoesEmailExist(string email)
    {
        return _users.Any(u => u.Email == email);
    }

    public void Save(UserSignUpVm user)
    {
        _users.Add(user);
    }

    public User GetByEmail(string email)
    {
        var user = _users.FirstOrDefault(u => u.Email == email);
        return new User { Email = new Email(user.Email) };
    }
}
