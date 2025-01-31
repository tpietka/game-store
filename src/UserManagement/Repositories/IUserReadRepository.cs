using UserManagement.Dto;
using UserManagement.Entities;

namespace UserManagement.Repositories;
public interface IUserReadRepository
{
    bool DoesEmailExist(string email);
    User GetByEmail(string email);
}
