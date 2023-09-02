using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.DA.Repositories;
public class CryptocurrencyRepository : ICryptocurrencyRepository
{
    public Task AddAsync(Cryptocurrency cryptocurrency)
    {
        throw new NotSupportedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotSupportedException();
    }

    public Task<IEnumerable<Cryptocurrency>> GetAllAsync()
    {
        throw new NotSupportedException();
    }

    public Task<Cryptocurrency> GetByIdAsync(string id)
    {
        throw new NotSupportedException();
    }

    public Task UpdateAsync(Cryptocurrency cryptocurrency)
    {
        throw new NotSupportedException();
    }
}
