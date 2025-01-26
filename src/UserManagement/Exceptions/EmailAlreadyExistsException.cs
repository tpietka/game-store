namespace UserManagement.Exceptions;
public class EmailAlreadyExistsException : Exception
{
    private const string MESSAGE = "Email already exists";
    public EmailAlreadyExistsException() : base(MESSAGE)
    {}
}
