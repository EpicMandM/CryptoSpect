using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.DA.Repositories;
public class UserRepository : IUserRepository
{
    public Task AddAsync(User user)
    {
        throw new NotSupportedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotSupportedException();
    }

    public Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotSupportedException();
    }

    public Task<User> GetByIdAsync(Guid id)
    {
        throw new NotSupportedException();
    }

    public Task UpdateAsync(User user)
    {
        throw new NotSupportedException();
    }
}
