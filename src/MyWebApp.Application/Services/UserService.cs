
using MyWebApp.Application.Interfaces;

namespace MyWebApp.Application.Services
{   
    public class UserService : IUserService
    {
        public string CreateUser(string username, string password)
        {
            // Implementation for creating a user
            return "User created successfully.";
        }

        public bool ValidateUser(string username, string password)
        {
            // Implementation for validating a user
            return true;
        }

    }
}