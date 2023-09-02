using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CryptoSpect.Core.Models;

/// <summary>
/// Represents a cryptocurrency with its current and historical price data.
/// </summary>
/// <param name="Id">The unique identifier for the cryptocurrency, represented as an ObjectId in MongoDB.</param>
/// <param name="Name">The name of the cryptocurrency.</param>
/// <param name="Symbol">The trading symbol for the cryptocurrency.</param>
/// <param name="CurrentPrice">The current price of the cryptocurrency.</param>
/// <param name="HistoricalData">A read-only collection of historical price data for the cryptocurrency.</param>
public sealed record Cryptocurrency(
    [property: BsonId, BsonRepresentation(BsonType.ObjectId)] string Id,
    string Name,
    string Symbol,
    decimal CurrentPrice,
    IReadOnlyCollection<HistoricalData> HistoricalData
);
