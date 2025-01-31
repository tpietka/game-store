using UserManagement.Dto;
using UserManagement.Entities;
using UserManagement.Repositories;

namespace UserManagement.Services;
internal class UserService : IUserService
{
    private readonly IUserReadRepository _repository;
    public UserService(IUserReadRepository repository)
    {
        _repository = repository;
    }

    public User GetByEmail(string email)
    {
        return _repository.GetByEmail(email);
    }
}
