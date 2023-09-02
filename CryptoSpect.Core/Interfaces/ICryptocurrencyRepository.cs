using CryptoSpect.Core.Models;

namespace CryptoSpect.Core.Interfaces;

/// <summary>
/// Defines the contract for cryptocurrency-related repository operations.
/// </summary>
public interface ICryptocurrencyRepository
{
    /// <summary>
    /// Asynchronously retrieves a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency.</param>
    /// <returns>A Task representing the asynchronous operation, containing the Cryptocurrency.</returns>
    Task<Cryptocurrency> GetByIdAsync(string id);

    /// <summary>
    /// Asynchronously retrieves all cryptocurrencies.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Cryptocurrencies.</returns>
    Task<IEnumerable<Cryptocurrency>> GetAllAsync();

    /// <summary>
    /// Asynchronously adds a new cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task AddAsync(Cryptocurrency cryptocurrency);

    /// <summary>
    /// Asynchronously updates an existing cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task UpdateAsync(Cryptocurrency cryptocurrency);

    /// <summary>
    /// Asynchronously deletes a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task DeleteAsync(string id);
}
