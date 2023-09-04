using Microsoft.AspNetCore.Mvc;
using CryptoSpect.Service.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Utility.Logging;

namespace CryptoSpect.Controllers;

/// <summary>
/// Provides API endpoints for managing cryptocurrencies.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public sealed class CryptocurrencyController : ControllerBase
{
    private readonly ICryptocurrencyService _cryptocurrencyService;
    private readonly ILogger<CryptocurrencyController> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="CryptocurrencyController"/> class.
    /// </summary>
    /// <param name="cryptocurrencyService">The service responsible for handling cryptocurrency operations.</param>
    /// <param name="logger">The logger used to log events and issues related to the CryptocurrencyController.</param>
    public CryptocurrencyController(ICryptocurrencyService cryptocurrencyService, ILogger<CryptocurrencyController> logger)
    {
        _cryptocurrencyService = cryptocurrencyService;
        _logger = logger;
    }

    /// <summary>
    /// Retrieves all cryptocurrencies.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            LogEvents.LogGetAllCryptocurrenciesStarted(_logger, arg2: null);

            var cryptocurrencies = await _cryptocurrencyService.GetAllAsync().ConfigureAwait(false);

            if (cryptocurrencies?.Any() ?? true)
            {
                return NotFound();
            }

            LogEvents.LogGetAllCryptocurrenciesCompleted(_logger, cryptocurrencies.Count(), arg3: null);
            return Ok(cryptocurrencies);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Retrieves a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency.</param>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        try
        {
            var cryptocurrency = await _cryptocurrencyService.GetByIdAsync(id).ConfigureAwait(false);
            if (cryptocurrency is null)
            {
                LogEvents.LogCryptocurrencyNotFound(_logger, id, arg3: null);
                return NotFound();
            }

            return Ok(cryptocurrency);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }
    /// <summary>
    /// Adds a new cryptocurrency.
    /// </summary>
    /// <param name="newCryptocurrency">The cryptocurrency to add.</param>
    [HttpPost]
    public async Task<IActionResult> AddAsync([FromBody] Cryptocurrency newCryptocurrency)
    {
        if (newCryptocurrency is null)
        {
            LogEvents.LogNullCryptocurrency(_logger, arg2: null);
            return BadRequest();
        }
        try
        {
            await _cryptocurrencyService.AddAsync(newCryptocurrency).ConfigureAwait(false);
            LogEvents.LogCryptocurrencyAdded(_logger, newCryptocurrency.Id, arg3: null);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = newCryptocurrency.Id }, newCryptocurrency);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Updates an existing cryptocurrency.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency to update.</param>
    /// <param name="updatedCryptocurrency">The updated cryptocurrency data.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(string id, [FromBody] Cryptocurrency updatedCryptocurrency)
    {
        if (updatedCryptocurrency is null)
        {
            LogEvents.LogNullCryptocurrency(_logger, arg2: null);
            return BadRequest();
        }
        if (!string.Equals(id, updatedCryptocurrency.Id, StringComparison.Ordinal))
        {
            LogEvents.LogCryptocurrencyNotFound(_logger, updatedCryptocurrency.Id, arg3: null);
            return BadRequest();
        }
        try
        {
            await _cryptocurrencyService.UpdateAsync(updatedCryptocurrency!).ConfigureAwait(false);
            LogEvents.LogCryptocurrencyUpdated(_logger, updatedCryptocurrency.Id, arg3: null);
            return NoContent();
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Deletes a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency to delete.</param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        try
        {
            await _cryptocurrencyService.DeleteAsync(id).ConfigureAwait(false);
            LogEvents.LogCryptocurrencyDeleted(_logger, id, arg3: null);
            return NoContent();
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }
}
