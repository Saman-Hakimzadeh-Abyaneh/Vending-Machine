using Domain.Model;

namespace Domain.Interfaces
{
    public interface IUserService
    {
        User Get(string username, string password);
    }
}