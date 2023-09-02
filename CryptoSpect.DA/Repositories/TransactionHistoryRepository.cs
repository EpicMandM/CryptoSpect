using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.DA.Repositories;
public class TransactionHistoryRepository : ITransactionHistoryRepository
{
    public Task AddAsync(TransactionHistory transactionHistory)
    {
        throw new NotSupportedException();
    }

    public Task DeleteAsync(Guid transactionId)
    {
        throw new NotSupportedException();
    }

    public Task<IEnumerable<TransactionHistory>> GetAllAsync()
    {
        throw new NotSupportedException();
    }

    public Task<TransactionHistory> GetByIdAsync(Guid transactionId)
    {
        throw new NotSupportedException();
    }

    public Task UpdateAsync(TransactionHistory transactionHistory)
    {
        throw new NotSupportedException();
    }
}
