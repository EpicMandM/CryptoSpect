using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.DA.Repositories;

/// <summary>
/// Provides implementation for the IUserRepository interface.
/// </summary>
public sealed class UserRepository : IUserRepository
{
    /// <summary>
    /// Asynchronously adds a new user.
    /// </summary>
    /// <param name="user">The user to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task AddAsync(User user)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously deletes a user by their identifier.
    /// </summary>
    /// <param name="id">The identifier of the user to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task DeleteAsync(Guid id)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously retrieves all users.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Users.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously retrieves a user by their identifier.
    /// </summary>
    /// <param name="id">The identifier of the user to retrieve.</param>
    /// <returns>A Task representing the asynchronous operation, containing the User.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task<User> GetByIdAsync(Guid id)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously updates a user.
    /// </summary>
    /// <param name="user">The user to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task UpdateAsync(User user)
    {
        throw new NotSupportedException();
    }
}
