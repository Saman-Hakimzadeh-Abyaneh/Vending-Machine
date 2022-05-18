using Domain.Model;
using Domain.Interfaces;

namespace VendingMachine.Services
{
    public class UsersService : IUserService
    {
        public User Get(string username, string password)
        {
            return new User
            {
                Username = "Elliot A.",
                AvatarPath = "pack://application:,,,/VendingMachine;component/Assets/avatar.png"
            };
        }
    }
}