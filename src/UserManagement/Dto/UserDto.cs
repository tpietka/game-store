using UserManagement.Entities;

namespace UserManagement.Dto;
public record UserDto(UserName UserName, PhoneNumber PhoneNumber, Email Email);
