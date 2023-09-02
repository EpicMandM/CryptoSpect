using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.DA.Repositories;

/// <summary>
/// Provides implementation for the ICryptocurrencyRepository interface.
/// </summary>
public sealed class CryptocurrencyRepository : ICryptocurrencyRepository
{
    /// <summary>
    /// Asynchronously adds a new cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task AddAsync(Cryptocurrency cryptocurrency)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously deletes a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the cryptocurrency to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task DeleteAsync(string id)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously retrieves all cryptocurrencies.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Cryptocurrencies.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task<IEnumerable<Cryptocurrency>> GetAllAsync()
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously retrieves a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the cryptocurrency to retrieve.</param>
    /// <returns>A Task representing the asynchronous operation, containing the Cryptocurrency.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task<Cryptocurrency> GetByIdAsync(string id)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously updates a cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task UpdateAsync(Cryptocurrency cryptocurrency)
    {
        throw new NotSupportedException();
    }
}
