using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CryptoSpect.Models;

public record Cryptocurrency([property: BsonId, BsonRepresentation(BsonType.ObjectId)] string Id, string Name, string Symbol, decimal CurrentPrice, IReadOnlyCollection<HistoricalData> HistoricalData);

public record HistoricalData(DateTimeOffset Timestamp, decimal Price);
