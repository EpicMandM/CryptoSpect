using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task AddUserAsync(User user)
    {
        await _userRepository.AddAsync(user).ConfigureAwait(false);
    }

    public async Task DeleteUserAsync(Guid id)
    {
        await _userRepository.DeleteAsync(id).ConfigureAwait(false);
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllAsync().ConfigureAwait(false);
    }

    public async Task<User> GetUserByIdAsync(Guid id)
    {
        return await _userRepository.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task UpdateUserAsync(User user)
    {
        await _userRepository.UpdateAsync(user).ConfigureAwait(false);
    }
}
