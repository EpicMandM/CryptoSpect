namespace CryptoSpect.Models;

public record TransactionHistory(int UserId, string CryptocurrencyId, string TransactionType, decimal Amount, DateTimeOffset DateTime);
