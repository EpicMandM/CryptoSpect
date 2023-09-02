namespace CryptoSpect.Core.Models;

public record User(Guid Id, string Username, string Email, string PasswordHash, DateTimeOffset LastLogin);
