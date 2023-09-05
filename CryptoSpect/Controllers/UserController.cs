using CryptoSpect.Core.Models;
using CryptoSpect.Service.Interfaces;
using CryptoSpect.Utility.Logging;
using Microsoft.AspNetCore.Mvc;

namespace CryptoSpect.Controllers;

/// <summary>
/// Provides API endpoints for managing users.
/// </summary>
public sealed class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ILogger _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserController"/> class.
    /// </summary>
    /// <param name="userService">The user service.</param>
    /// <param name="logger">The logger used to log events and issues related to the UserController.</param>
    public UserController(IUserService userService, ILogger logger)
    {
        _userService = userService;
        _logger = logger;
    }

    /// <summary>
    /// Retrieves all users.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var users = await _userService.GetAllAsync().ConfigureAwait(false);
            return Ok(users);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Retrieves a user by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the user.</param>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        try
        {
            var user = await _userService.GetByIdAsync(id).ConfigureAwait(false);
            return Ok(user);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
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
            LogEvents.LogNullUser(_logger, arg2: null);
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            LogEvents.LogInvalidModelState(_logger, string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)), null);
            return BadRequest(ModelState);
        }
        try
        {
            await _userService.AddAsync(newUser).ConfigureAwait(false);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = newUser.Id }, newUser);
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="id">The unique identifier for the user to update.</param>
    /// <param name="updatedUser">The updated user data.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] User updatedUser)
    {
        if (updatedUser is null)
        {
            LogEvents.LogNullUser(_logger, arg2: null);
            return BadRequest();
        }
        if (!Equals(id, updatedUser.Id))
        {
            LogEvents.LogNoUsersFound(_logger, null);
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            LogEvents.LogInvalidModelState(_logger, string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)), null);
            return BadRequest(ModelState);
        }
        try
        {
            await _userService.UpdateAsync(updatedUser).ConfigureAwait(false);
            return NoContent();
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }

    /// <summary>
    /// Deletes a user by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the user to delete.</param>
    [HttpDelete("{id}")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        try
        {
            await _userService.DeleteAsync(id).ConfigureAwait(false);
            LogEvents.LogUserDeleted(_logger, id, arg3: null);
            return NoContent();
        }
        catch (Exception e)
        {
            LogEvents.LogUnexpectedError(_logger, e);
            return StatusCode(500, "Internal server error");
        }
    }
}
