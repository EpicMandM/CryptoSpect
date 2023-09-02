using CryptoSpect.Core.Models;

namespace CryptoSpect.Service.Interfaces;
public interface ITransactionHistoryService
{
    Task<TransactionHistory> GetTransactionHistoryByIdAsync(Guid id);
    Task<IEnumerable<TransactionHistory>> GetAllTransactionsAsync();
    Task AddTransactionAsync(TransactionHistory transactionHistory);
    Task UpdateTransactionAsync(TransactionHistory transactionHistory);
    Task DeleteTransactionAsync(Guid id);

}
