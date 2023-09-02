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
    public Task AddCryptocurrencyAsync(Cryptocurrency cryptocurrency)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCryptocurrencyAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Cryptocurrency>> GetAllCryptocurrenciesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Cryptocurrency> GetCryptocurrencyByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCryptocurrencyAsync(Cryptocurrency cryptocurrency)
    {
        throw new NotImplementedException();
    }
}
