

namespace MyWebApp.Application.Interfaces
{
    public interface IUserService
    {
        // Interface methods and properties go here

        string CreateUser(string username, string password);
        bool ValidateUser(string username, string password);
    }

}

