using Microsoft.AspNetCore.Mvc;
using CryptoSpect.Service.Interfaces;
using CryptoSpect.Core.Models;

namespace CryptoSpect.Controllers;

/// <summary>
/// Provides API endpoints for managing cryptocurrencies.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CryptocurrencyController : ControllerBase
{
    private readonly ICryptocurrencyService _cryptocurrencyService;

    /// <summary>
    /// Initializes a new instance of the <see cref="CryptocurrencyController"/> class.
    /// </summary>
    /// <param name="cryptocurrencyService">The cryptocurrency service.</param>
    public CryptocurrencyController(ICryptocurrencyService cryptocurrencyService)
    {
        _cryptocurrencyService = cryptocurrencyService;
    }

    /// <summary>
    /// Retrieves all cryptocurrencies.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _cryptocurrencyService.GetAllAsync().ConfigureAwait(false));
    }

    /// <summary>
    /// Retrieves a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency.</param>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var cryptocurrency = await _cryptocurrencyService.GetByIdAsync(id).ConfigureAwait(false);
        if (cryptocurrency is null)
            return NotFound();

        return Ok(cryptocurrency);
    }

    /// <summary>
    /// Adds a new cryptocurrency.
    /// </summary>
    /// <param name="newCryptocurrency">The cryptocurrency to add.</param>
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Cryptocurrency newCryptocurrency)
    {
        await _cryptocurrencyService.AddAsync(newCryptocurrency).ConfigureAwait(false);
        return CreatedAtAction(nameof(GetByIdAsync), new { id = newCryptocurrency.Id }, newCryptocurrency);
    }

    /// <summary>
    /// Updates an existing cryptocurrency.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency to update.</param>
    /// <param name="updatedCryptocurrency">The updated cryptocurrency data.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] Cryptocurrency updatedCryptocurrency)
    {
        if (!string.Equals(id, updatedCryptocurrency.Id, StringComparison.Ordinal))
            return BadRequest();

        await _cryptocurrencyService.UpdateAsync(updatedCryptocurrency).ConfigureAwait(false);
        return NoContent();
    }

    /// <summary>
    /// Deletes a cryptocurrency by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the cryptocurrency to delete.</param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _cryptocurrencyService.DeleteAsync(id).ConfigureAwait(false);
        return NoContent();
    }
}
