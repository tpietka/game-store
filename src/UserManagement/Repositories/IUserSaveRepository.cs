using UserManagement.ViewModels;

namespace UserManagement.Repositories;
public interface IUserSaveRepository
{
    void Save(UserSignUpVm user);
}
