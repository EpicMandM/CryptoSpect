using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;
public class CryptocurrencyService : ICryptocurrencyService
{
    private readonly ICryptocurrencyRepository _cryptocurrencyRepository;
    public CryptocurrencyService(ICryptocurrencyRepository cryptocurrencyRepository)
    {
        _cryptocurrencyRepository = cryptocurrencyRepository;
    }
    public async Task AddCryptocurrencyAsync(Cryptocurrency cryptocurrency)
    {
        await _cryptocurrencyRepository.AddAsync(cryptocurrency).ConfigureAwait(false);
    }

    public async Task DeleteCryptocurrencyAsync(string id)
    {
        await _cryptocurrencyRepository.DeleteAsync(id).ConfigureAwait(false);
    }

    public async Task<IEnumerable<Cryptocurrency>> GetAllCryptocurrenciesAsync()
    {
        return await _cryptocurrencyRepository.GetAllAsync().ConfigureAwait(false);
    }

    public async Task<Cryptocurrency> GetCryptocurrencyByIdAsync(string id)
    {
        return await _cryptocurrencyRepository.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task UpdateCryptocurrencyAsync(Cryptocurrency cryptocurrency)
    {
        await _cryptocurrencyRepository.UpdateAsync(cryptocurrency).ConfigureAwait(false);
    }
}
