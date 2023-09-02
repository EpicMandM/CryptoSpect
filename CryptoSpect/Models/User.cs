namespace CryptoSpect.Models;

public record User(int Id, string Username, string Email, string PasswordHash, DateTimeOffset LastLogin);
