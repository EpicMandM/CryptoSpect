using CryptoSpect.Core.Models;
namespace CryptoSpect.Service.Interfaces;
public interface ICryptocurrencyService
{
    Task<Cryptocurrency> GetCryptocurrencyByIdAsync(string id);
    Task<IEnumerable<Cryptocurrency>> GetAllCryptocurrenciesAsync();
    Task AddCryptocurrencyAsync(Cryptocurrency cryptocurrency);
    Task UpdateCryptocurrencyAsync(Cryptocurrency cryptocurrency);
    Task DeleteCryptocurrencyAsync(string id);
}
