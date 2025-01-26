using UserManagement.Entities;

namespace UserManagement.Repositories;
public interface IUserReadRepository
{
    bool DoesEmailExist(string email);
}
