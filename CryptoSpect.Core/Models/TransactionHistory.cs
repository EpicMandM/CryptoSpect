namespace CryptoSpect.Core.Models;

public record TransactionHistory(Guid UserId, string CryptocurrencyId, string TransactionType, decimal Amount, DateTimeOffset DateTime);
