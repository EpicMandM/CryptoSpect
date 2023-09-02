using CryptoSpect.Core.Models;

namespace CryptoSpect.Service.Interfaces;

/// <summary>
/// Defines the contract for cryptocurrency-related services.
/// </summary>
public interface ICryptocurrencyService
{
    /// <summary>
    /// Asynchronously retrieves a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency.</param>
    /// <returns>A Task representing the asynchronous operation, containing the Cryptocurrency.</returns>
    Task<Cryptocurrency> GetCryptocurrencyByIdAsync(string id);

    /// <summary>
    /// Asynchronously retrieves all cryptocurrencies.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Cryptocurrencies.</returns>
    Task<IEnumerable<Cryptocurrency>> GetAllCryptocurrenciesAsync();

    /// <summary>
    /// Asynchronously adds a new cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task AddCryptocurrencyAsync(Cryptocurrency cryptocurrency);

    /// <summary>
    /// Asynchronously updates an existing cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task UpdateCryptocurrencyAsync(Cryptocurrency cryptocurrency);

    /// <summary>
    /// Asynchronously deletes a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task DeleteCryptocurrencyAsync(string id);
}
