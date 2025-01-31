using UserManagement.Dto;
using UserManagement.Entities;

namespace UserManagement.Repositories;
internal class UserReadRepository : IUserReadRepository
{
    public bool DoesEmailExist(string email)
    {
        throw new NotImplementedException();
    }

    public User GetByEmail(string email)
    {
        throw new NotImplementedException();
    }
}
