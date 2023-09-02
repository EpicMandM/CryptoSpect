using CryptoSpect.Core.Models;

namespace CryptoSpect.Core.Interfaces;
public interface ITransactionHistoryRepository
{
    Task<TransactionHistory> GetByIdAsync(Guid transactionId);
    Task<IEnumerable<TransactionHistory>> GetAllAsync();
    Task AddAsync(TransactionHistory transactionHistory);
    Task UpdateAsync(TransactionHistory transactionHistory);
    Task DeleteAsync(Guid transactionId);
}
