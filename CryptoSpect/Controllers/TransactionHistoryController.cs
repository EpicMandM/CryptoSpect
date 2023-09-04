using Microsoft.AspNetCore.Mvc;
using CryptoSpect.Service.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Utility.Logging;

namespace CryptoSpect.Controllers;

/// <summary>
/// Provides API endpoints for managing transaction histories.
/// </summary>
public sealed class TransactionHistoryController : ControllerBase
{
    private readonly ITransactionHistoryService _transactionHistoryService;
    private readonly ILogger _logger;
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryController"/> class.
    /// </summary>
    /// <param name="transactionHistoryService">The transaction history service.</param>
    /// <param name="logger">The logger used to log events and issues related to the TransactionHistoryController.</param>

    public TransactionHistoryController(ITransactionHistoryService transactionHistoryService, ILogger logger)
    {
        _transactionHistoryService = transactionHistoryService;
        _logger = logger;
    }

    /// <summary>
    /// Retrieves all transaction histories.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            LogEvents.LogGetAllUsersStarted(_logger, arg2: null);
            var transactionHistories = await _transactionHistoryService.GetAllAsync().ConfigureAwait(false);

            if (transactionHistories?.Any() ?? true)
            {
                LogEvents.LogNoUsersFound(_logger, arg2: null);
                return NotFound();
            }

            LogEvents.LogGetAllUsersCompleted(_logger, transactionHistories.Count(), arg3: null);
            return Ok(transactionHistories);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Retrieves a transaction history by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the transaction history.</param>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        try
        {
            var transactionHistory = await _transactionHistoryService.GetByIdAsync(id).ConfigureAwait(false);
            if (transactionHistory is null)
            {
                LogEvents.LogTransactionHistoryNotFound(_logger, id, arg3: null);
                return NotFound();
            }

            return Ok(transactionHistory);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Adds a new transaction history.
    /// </summary>
    /// <param name="newTransactionHistory">The transaction history to add.</param>
    [HttpPost]
    public async Task<IActionResult> AddAsync([FromBody] TransactionHistory newTransactionHistory)
    {
        if (newTransactionHistory is null)
        {
            LogEvents.LogNullTransactionHistory(_logger, arg2: null);
            return BadRequest();
        }
        try
        {
            await _transactionHistoryService.AddAsync(newTransactionHistory).ConfigureAwait(false);
            LogEvents.LogTransactionHistoryUpdated(_logger, newTransactionHistory.UserId, arg3: null);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = newTransactionHistory.UserId }, newTransactionHistory);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Updates an existing transaction history.
    /// </summary>
    /// <param name="id">The unique identifier for the transaction history to update.</param>
    /// <param name="updatedTransactionHistory">The updated transaction history data.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TransactionHistory updatedTransactionHistory)
    {
        if (updatedTransactionHistory is null)
        {
            LogEvents.LogNullTransactionHistory(_logger, arg2: null);
            return BadRequest();
        }
        if (!Equals(id, updatedTransactionHistory.UserId))
        {
            LogEvents.LogNoTransactionHistoriesFound(_logger, arg2: null);
            return BadRequest();
        }

        try
        {
            await _transactionHistoryService.UpdateAsync(updatedTransactionHistory!).ConfigureAwait(false);
            return NoContent();
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Deletes a transaction history by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the transaction history to delete.</param>
    [HttpDelete("{id}")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        try
        {
            await _transactionHistoryService.DeleteAsync(id).ConfigureAwait(false);
            LogEvents.LogTransactionHistoryDeleted(_logger, id, arg3: null);
            return NoContent();
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }
}
