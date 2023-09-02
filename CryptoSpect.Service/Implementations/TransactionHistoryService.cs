using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;

/// <summary>
/// Provides implementation for the ITransactionHistoryService interface.
/// </summary>
public sealed class TransactionHistoryService : ITransactionHistoryService
{
    private readonly ITransactionHistoryRepository _transactionHistoryRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryService"/> class.
    /// </summary>
    /// <param name="transactionHistoryRepository">The transaction history repository.</param>
    public TransactionHistoryService(ITransactionHistoryRepository transactionHistoryRepository)
    {
        _transactionHistoryRepository = transactionHistoryRepository;
    }

    /// <summary>
    /// Asynchronously adds a new transaction history.
    /// </summary>
    /// <param name="transactionHistory">The transaction history to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task AddTransactionAsync(TransactionHistory transactionHistory)
    {
        await _transactionHistoryRepository.AddAsync(transactionHistory).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously deletes a transaction history by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the transaction history to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task DeleteTransactionAsync(Guid id)
    {
        await _transactionHistoryRepository.DeleteAsync(id).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously retrieves all transaction histories.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of TransactionHistories.</returns>
    public async Task<IEnumerable<TransactionHistory>> GetAllTransactionsAsync()
    {
        return await _transactionHistoryRepository.GetAllAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously retrieves a transaction history by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the transaction history to retrieve.</param>
    /// <returns>A Task representing the asynchronous operation, containing the TransactionHistory.</returns>
    public async Task<TransactionHistory> GetTransactionHistoryByIdAsync(Guid id)
    {
        return await _transactionHistoryRepository.GetByIdAsync(id).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously updates a transaction history.
    /// </summary>
    /// <param name="transactionHistory">The transaction history to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task UpdateTransactionAsync(TransactionHistory transactionHistory)
    {
        await _transactionHistoryRepository.UpdateAsync(transactionHistory).ConfigureAwait(false);
    }
}
