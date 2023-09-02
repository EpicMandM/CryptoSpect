using CryptoSpect.Core.Models;

namespace CryptoSpect.Service.Interfaces;
internal interface IUserService
{
    Task<User> GetUserByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid id);
}
