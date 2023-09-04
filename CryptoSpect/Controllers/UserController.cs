using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CryptoSpect.Controllers;

/// <summary>
/// Provides API endpoints for managing users.
/// </summary>
public sealed class UserController : ControllerBase
{
    private readonly IUserService _userService;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserController"/> class.
    /// </summary>
    /// <param name="userService">The user service.</param>
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Retrieves all users.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _userService.GetAllAsync().ConfigureAwait(false));
    }

    /// <summary>
    /// Retrieves a user by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the user.</param>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        return Ok(await _userService.GetByIdAsync(id).ConfigureAwait(false));
    }

    /// <summary>
    /// Adds a new user.
    /// </summary>
    /// <param name="newUser">The user to add.</param>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddAsync(User newUser)
    {
        if (newUser is null)
        {
            return BadRequest();
        }
        await _userService.AddAsync(newUser).ConfigureAwait(false);
        return CreatedAtAction(nameof(GetByIdAsync), new { id = newUser.Id }, newUser);
    }

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="id">The unique identifier for the user to update.</param>
    /// <param name="updatedUser">The updated user data.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] User updatedUser)
    {
        if (updatedUser is null || !Equals(id, updatedUser.Id))
        {
            return BadRequest();
        }
        await _userService.UpdateAsync(updatedUser).ConfigureAwait(false);
        return NoContent();
    }

    /// <summary>
    /// Deletes a user by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the user to delete.</param>
    [HttpDelete("{id}")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        await _userService.DeleteAsync(id).ConfigureAwait(false);
        return NoContent();
    }
}
