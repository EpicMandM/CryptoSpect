using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;

/// <summary>
/// Provides implementation for the IUserService interface.
/// </summary>
public sealed class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserService"/> class.
    /// </summary>
    /// <param name="userRepository">The user repository.</param>
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Asynchronously adds a new user.
    /// </summary>
    /// <param name="user">The user to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task AddAsync(User user)
    {
        await _userRepository.AddAsync(user).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously deletes a user by their identifier.
    /// </summary>
    /// <param name="id">The identifier of the user to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task DeleteAsync(Guid id)
    {
        await _userRepository.DeleteAsync(id).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously retrieves all users.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Users.</returns>
    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _userRepository.GetAllAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously retrieves a user by their identifier.
    /// </summary>
    /// <param name="id">The identifier of the user to retrieve.</param>
    /// <returns>A Task representing the asynchronous operation, containing the User.</returns>
    public async Task<User> GetByIdAsync(Guid id)
    {
        return await _userRepository.GetByIdAsync(id).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously updates a user.
    /// </summary>
    /// <param name="user">The user to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task UpdateAsync(User user)
    {
        await _userRepository.UpdateAsync(user).ConfigureAwait(false);
    }
}
