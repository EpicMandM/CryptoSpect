using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;
public class TransactionHistoryService : ITransactionHistoryService
{
    private readonly ITransactionHistoryRepository _transactionHistoryRepository;

    public TransactionHistoryService(ITransactionHistoryRepository transactionHistoryRepository)
    {
        _transactionHistoryRepository = transactionHistoryRepository;
    }

    public async Task AddTransactionAsync(TransactionHistory transactionHistory)
    {
        await _transactionHistoryRepository.AddAsync(transactionHistory).ConfigureAwait(false);
    }

    public async Task DeleteTransactionAsync(Guid id)
    {
        await _transactionHistoryRepository.DeleteAsync(id).ConfigureAwait(false);
    }

    public async Task<IEnumerable<TransactionHistory>> GetAllTransactionsAsync()
    {
        return await _transactionHistoryRepository.GetAllAsync().ConfigureAwait(false);
    }

    public async Task<TransactionHistory> GetTransactionHistoryByIdAsync(Guid id)
    {
        return await _transactionHistoryRepository.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task UpdateTransactionAsync(TransactionHistory transactionHistory)
    {
        await _transactionHistoryRepository.UpdateAsync(transactionHistory).ConfigureAwait(false);
    }
}
