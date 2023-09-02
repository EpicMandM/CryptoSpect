using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;

/// <summary>
/// Provides implementation for the ICryptocurrencyService interface.
/// </summary>
public sealed class CryptocurrencyService : ICryptocurrencyService
{
    private readonly ICryptocurrencyRepository _cryptocurrencyRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="CryptocurrencyService"/> class.
    /// </summary>
    /// <param name="cryptocurrencyRepository">The cryptocurrency repository.</param>
    public CryptocurrencyService(ICryptocurrencyRepository cryptocurrencyRepository)
    {
        _cryptocurrencyRepository = cryptocurrencyRepository;
    }

    /// <summary>
    /// Asynchronously adds a new cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task AddAsync(Cryptocurrency cryptocurrency)
    {
        await _cryptocurrencyRepository.AddAsync(cryptocurrency).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously deletes a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the cryptocurrency to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task DeleteAsync(string id)
    {
        await _cryptocurrencyRepository.DeleteAsync(id).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously retrieves all cryptocurrencies.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of Cryptocurrencies.</returns>
    public async Task<IEnumerable<Cryptocurrency>> GetAllAsync()
    {
        return await _cryptocurrencyRepository.GetAllAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously retrieves a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the cryptocurrency to retrieve.</param>
    /// <returns>A Task representing the asynchronous operation, containing the Cryptocurrency.</returns>
    public async Task<Cryptocurrency> GetByIdAsync(string id)
    {
        return await _cryptocurrencyRepository.GetByIdAsync(id).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously updates a cryptocurrency.
    /// </summary>
    /// <param name="cryptocurrency">The cryptocurrency to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task UpdateAsync(Cryptocurrency cryptocurrency)
    {
        await _cryptocurrencyRepository.UpdateAsync(cryptocurrency).ConfigureAwait(false);
    }
}
