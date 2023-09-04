using System.ComponentModel.DataAnnotations;

namespace CryptoSpect.Core.Models;

/// <summary>
/// Represents a user in the system.
/// </summary>
/// <param name="Id">The unique identifier for the user.</param>
/// <param name="Username">The username of the user.</param>
/// <param name="Email">The email address of the user.</param>
/// <param name="PasswordHash">The hashed password of the user.</param>
/// <param name="LastLogin">The last login time of the user.</param>
public sealed record User([Required] Guid Id, [Required, StringLength(100)] string Username, [Required, StringLength(255), EmailAddress] string Email, [Required] string PasswordHash, DateTimeOffset LastLogin);
