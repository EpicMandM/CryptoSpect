using CryptoSpect.Core.Models;

namespace CryptoSpect.Core.Interfaces;
public interface ICryptocurrencyRepository
{
    Task<Cryptocurrency> GetByIdAsync(string id);
    Task<IEnumerable<Cryptocurrency>> GetAllAsync();
    Task AddAsync(Cryptocurrency cryptocurrency);
    Task UpdateAsync(Cryptocurrency cryptocurrency);
    Task DeleteAsync(string id);
}
