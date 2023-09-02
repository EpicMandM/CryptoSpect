namespace CryptoSpect.Core.Models;

/// <summary>
/// Represents historical price data for a cryptocurrency.
/// </summary>
/// <param name="Timestamp">The date and time when the price was recorded.</param>
/// <param name="Price">The price of the cryptocurrency at the given timestamp.</param>
public sealed record HistoricalData(DateTimeOffset Timestamp, decimal Price);
