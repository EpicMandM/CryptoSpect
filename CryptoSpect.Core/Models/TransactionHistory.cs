using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CryptoSpect.Core.Models;

/// <summary>
/// Represents a transaction history in the system.
/// </summary>
/// <param name="UserId">The unique identifier for the user associated with the transaction.</param>
/// <param name="CryptocurrencyId">The identifier for the cryptocurrency involved in the transaction.</param>
/// <param name="TransactionType">The type of the transaction (e.g., "Buy", "Sell").</param>
/// <param name="Amount">The amount of cryptocurrency involved in the transaction.</param>
/// <param name="DateTime">The date and time when the transaction occurred.</param>
public sealed record TransactionHistory([Required] Guid UserId,
    [property: BsonRepresentation(BsonType.ObjectId)][Required] string CryptocurrencyId,
    [Required] string TransactionType,
    decimal Amount,
    DateTimeOffset DateTime);
