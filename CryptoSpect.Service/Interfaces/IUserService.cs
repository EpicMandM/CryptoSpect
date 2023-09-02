using CryptoSpect.Core.Models;

namespace CryptoSpect.Service.Interfaces;

/// <summary>
/// Defines the contract for user-related services.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Asynchronously retrieves a user by their identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the user.</param>
    /// <returns>A Task representing the asynchronous operation, containing the User.</returns>
    Task<User> GetUserByIdAsync(Guid id);

    /// <summary>
    /// Asynchronously retrieves all users.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Users.</returns>
    Task<IEnumerable<User>> GetAllUsersAsync();

    /// <summary>
    /// Asynchronously adds a new user.
    /// </summary>
    /// <param name="user">The user to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task AddUserAsync(User user);

    /// <summary>
    /// Asynchronously updates an existing user.
    /// </summary>
    /// <param name="user">The user to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task UpdateUserAsync(User user);

    /// <summary>
    /// Asynchronously deletes a user by their identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the user to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task DeleteUserAsync(Guid id);
}
