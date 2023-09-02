using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.DA.Repositories;

/// <summary>
/// Provides implementation for the ITransactionHistoryRepository interface.
/// </summary>
public sealed class TransactionHistoryRepository : ITransactionHistoryRepository
{
    /// <summary>
    /// Asynchronously adds a new transaction history.
    /// </summary>
    /// <param name="transactionHistory">The transaction history to add.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task AddAsync(TransactionHistory transactionHistory)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously deletes a transaction history by its identifier.
    /// </summary>
    /// <param name="transactionId">The identifier of the transaction history to delete.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task DeleteAsync(Guid transactionId)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously retrieves all transaction histories.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation, containing an IEnumerable of TransactionHistories.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task<IEnumerable<TransactionHistory>> GetAllAsync()
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously retrieves a transaction history by its identifier.
    /// </summary>
    /// <param name="transactionId">The identifier of the transaction history to retrieve.</param>
    /// <returns>A Task representing the asynchronous operation, containing the TransactionHistory.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task<TransactionHistory> GetByIdAsync(Guid transactionId)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Asynchronously updates a transaction history.
    /// </summary>
    /// <param name="transactionHistory">The transaction history to update.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <exception cref="NotSupportedException">Thrown when the method is not supported.</exception>
    public Task UpdateAsync(TransactionHistory transactionHistory)
    {
        throw new NotSupportedException();
    }
}
