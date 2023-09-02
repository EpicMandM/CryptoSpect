using CryptoSpect.Core.Models;

namespace CryptoSpect.Service.Interfaces;

/// <summary>
/// Defines the contract for transaction history-related services.
/// </summary>
public interface ITransactionHistoryService
{
    /// <summary>
    /// Asynchronously retrieves a transaction history by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the transaction history.</param>
    /// <returns>A Task representing the asynchronous operation, containing the TransactionHistory.</returns>
    Task<TransactionHistory> GetTransactionHistoryByIdAsync(Guid id);

    /// <summary>
    /// Asynchronously retrieves all transaction histories.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of TransactionHistories.</returns>
    Task<IEnumerable<TransactionHistory>> GetAllTransactionsAsync();

    /// <summary>
    /// Asynchronously adds a new transaction history.
    /// </summary>
    /// <param name="transactionHistory">The transaction history to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task AddTransactionAsync(TransactionHistory transactionHistory);

    /// <summary>
    /// Asynchronously updates an existing transaction history.
    /// </summary>
    /// <param name="transactionHistory">The transaction history to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task UpdateTransactionAsync(TransactionHistory transactionHistory);

    /// <summary>
    /// Asynchronously deletes a transaction history by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the transaction history to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task DeleteTransactionAsync(Guid id);
}
