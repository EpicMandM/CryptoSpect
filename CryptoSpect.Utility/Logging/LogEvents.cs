using Microsoft.Extensions.Logging;

namespace CryptoSpect.Utility.Logging;

/// <summary>
/// Defines logging events for various application scenarios.
/// </summary>
public static class LogEvents
{
    #region Cryptocurrency events

    /// <summary>
    /// Event indicating an attempt to add a null cryptocurrency.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNullCryptocurrency =
        LoggerMessage.Define(LogLevel.Warning, new EventId((int)LogEventId.NullCryptocurrency, "Null Cryptocurrency"), "Attempted to add a null cryptocurrency.");

    /// <summary>
    /// Event indicating a cryptocurrency with a specific ID was not found.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyNotFound =
        LoggerMessage.Define<string>(LogLevel.Warning, new EventId((int)LogEventId.CryptocurrencyNotFound, "Cryptocurrency Not Found"), "Cryptocurrency with ID '{Id}' was not found.");

    /// <summary>
    /// Event indicating a new cryptocurrency was added.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyAdded =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId((int)LogEventId.CryptocurrencyAdded, "Cryptocurrency Added"), "A new cryptocurrency with ID '{Id}' was added.");

    /// <summary>
    /// Event indicating a cryptocurrency was updated.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyUpdated =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId((int)LogEventId.CryptocurrencyUpdated, "Cryptocurrency Updated"), "A new cryptocurrency with ID '{Id}' was updated.");

    /// <summary>
    /// Event indicating a cryptocurrency was deleted.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyDeleted =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId((int)LogEventId.CryptocurrencyDeleted, "Cryptocurrency Deleted"), "A new cryptocurrency with ID '{Id}' was deleted.");

    /// <summary>
    /// Event indicating the start of the process to retrieve all cryptocurrencies.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogGetAllCryptocurrenciesStarted =
        LoggerMessage.Define(LogLevel.Information, new EventId((int)LogEventId.GetAllCryptocurrenciesStarted, "GetAllCryptocurrenciesStarted"), "Started retrieving all cryptocurrencies.");

    /// <summary>
    /// Event indicating the successful completion of the process to retrieve all cryptocurrencies.
    /// </summary>
    public static readonly Action<ILogger, int, Exception?> LogGetAllCryptocurrenciesCompleted =
        LoggerMessage.Define<int>(LogLevel.Information, new EventId((int)LogEventId.GetAllCryptocurrenciesCompleted, "GetAllCryptocurrenciesCompleted"), "Successfully retrieved {Count} cryptocurrencies.");

    /// <summary>
    /// Event indicating that no cryptocurrencies were found.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNoCryptocurrenciesFound =
        LoggerMessage.Define(LogLevel.Warning, new EventId((int)LogEventId.NoCryptocurrenciesFound, "NoCryptocurrenciesFound"), "No cryptocurrencies found.");

    #endregion

    #region User events

    /// <summary>
    /// Event indicating an attempt to add a null user.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNullUser =
            LoggerMessage.Define(LogLevel.Warning, new EventId((int)LogEventId.NullUser, "Null User"), "Attempted to add a null user.");

    /// <summary>
    /// Event indicating a user with a specific ID was not found.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogUserNotFound =
        LoggerMessage.Define<string>(LogLevel.Warning, new EventId((int)LogEventId.UserNotFound, "User Not Found"), "User with ID '{Id}' was not found.");

    /// <summary>
    /// Event indicating a new user was added.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogUserAdded =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId((int)LogEventId.UserAdded, "User Added"), "A new user with ID '{Id}' was added.");

    /// <summary>
    /// Event indicating a user was updated.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogUserUpdated =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId((int)LogEventId.UserUpdated, "User Updated"), "A user with ID '{Id}' was updated.");

    /// <summary>
    /// Event indicating a user was deleted.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogUserDeleted =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId((int)LogEventId.UserDeleted, "User Deleted"), "A user with ID '{Id}' was deleted.");

    /// <summary>
    /// Event indicating the start of the process to retrieve all users.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogGetAllUsersStarted =
        LoggerMessage.Define(LogLevel.Information, new EventId((int)LogEventId.GetAllUsersStarted, "GetAllUsersStarted"), "Started retrieving all users.");

    /// <summary>
    /// Event indicating the successful completion of the process to retrieve all users.
    /// </summary>
    public static readonly Action<ILogger, int, Exception?> LogGetAllUsersCompleted =
        LoggerMessage.Define<int>(LogLevel.Information, new EventId((int)LogEventId.GetAllUsersCompleted, "GetAllUsersCompleted"), "Successfully retrieved {Count} users.");

    /// <summary>
    /// Event indicating that no users were found during the retrieval process.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNoUsersFound =
        LoggerMessage.Define(LogLevel.Warning, new EventId((int)LogEventId.NoUsersFound, "NoUsersFound"), "No users found.");

    #endregion

    #region TransactionHistory events

    /// <summary>
    /// Event indicating an attempt to add a null transaction history.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNullTransactionHistory =
        LoggerMessage.Define(LogLevel.Warning, new EventId((int)LogEventId.NullTransactionHistory, "Null TransactionHistory"), "Attempted to add a null transaction history.");

    /// <summary>
    /// Event indicating a transaction history with a specific ID was not found.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryNotFound =
        LoggerMessage.Define<Guid>(LogLevel.Warning, new EventId((int)LogEventId.TransactionHistoryNotFound, "TransactionHistory Not Found"), "TransactionHistory with ID '{Id}' was not found.");

    /// <summary>
    /// Event indicating a new transaction history was added.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryAdded =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId((int)LogEventId.TransactionHistoryAdded, "TransactionHistory Added"), "A new transaction history with ID '{Id}' was added.");

    /// <summary>
    /// Event indicating a transaction history was updated.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryUpdated =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId((int)LogEventId.TransactionHistoryUpdated, "TransactionHistory Updated"), "A transaction history with ID '{Id}' was updated.");

    /// <summary>
    /// Event indicating a transaction history was deleted.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryDeleted =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId((int)LogEventId.TransactionHistoryDeleted, "TransactionHistory Deleted"), "A transaction history with ID '{Id}' was deleted.");
    /// <summary>
    /// Event indicating the start of the process to retrieve all cryptocurrencies.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogGetAllTransactionHistoriesStarted =
        LoggerMessage.Define(LogLevel.Information, new EventId((int)LogEventId.GetAllTransactionHistoriesStarted, "GetAllTransactionHistoriesStarted"), "Started retrieving transaction histories.");

    /// <summary>
    /// Event indicating the successful completion of the process to retrieve all cryptocurrencies.
    /// </summary>
    public static readonly Action<ILogger, int, Exception?> LogGetAllTransactionHistoriesCompleted =
        LoggerMessage.Define<int>(LogLevel.Information, new EventId((int)LogEventId.GetAllTransactionHistoriesCompleted, "GetAllTransactionHistoriesCompleted"), "Successfully retrieved {Count} transaction histories.");

    /// <summary>
    /// Event indicating that no cryptocurrencies were found.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNoTransactionHistoriesFound =
        LoggerMessage.Define(LogLevel.Warning, new EventId((int)LogEventId.NoTransactionHistoriesFound, "NoTransactionHistoriesFound"), "No transaction histories found.");

    #endregion

    #region General events

    /// <summary>
    /// Event indicating an error occurred while accessing the database.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogDatabaseError =
        LoggerMessage.Define(LogLevel.Error, new EventId((int)LogEventId.DatabaseError, "Database Error"), "An error occurred while accessing the database.");

    /// <summary>
    /// Event indicating an error occurred while accessing an external API.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogExternalApiError =
        LoggerMessage.Define<string>(LogLevel.Error, new EventId((int)LogEventId.ExternalApiError, "External API Error"), "An error occurred while accessing the external API: '{ApiName}'.");

    /// <summary>
    /// Event indicating an unexpected error occurred.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogUnexpectedError =
        LoggerMessage.Define(LogLevel.Critical, new EventId((int)LogEventId.UnexpectedError, "Unexpected Error"), "An unexpected error occurred.");
    #endregion
}

/// <summary>
/// Defines the event IDs used for logging.
/// </summary>
#pragma warning disable MA0048 // File name must match type name
public enum LogEventId
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Represents the default or uninitialized state for logging events.
    /// </summary>
    None = 0,

    #region Cryptocurrency events
    /// <summary>
    /// Indicates an attempt to add a null cryptocurrency.
    /// </summary>
    NullCryptocurrency = 100,

    /// <summary>
    /// Indicates that a cryptocurrency with a specified ID was not found.
    /// </summary>
    CryptocurrencyNotFound,

    /// <summary>
    /// Indicates that a new cryptocurrency was added.
    /// </summary>
    CryptocurrencyAdded,

    /// <summary>
    /// Indicates that a cryptocurrency was updated.
    /// </summary>
    CryptocurrencyUpdated,

    /// <summary>
    /// Indicates that a cryptocurrency was deleted.
    /// </summary>
    CryptocurrencyDeleted,

    /// <summary>
    /// Indicates the start of retrieving all cryptocurrencies.
    /// </summary>
    GetAllCryptocurrenciesStarted,

    /// <summary>
    /// Indicates the successful retrieval of all cryptocurrencies.
    /// </summary>
    GetAllCryptocurrenciesCompleted,

    /// <summary>
    /// Indicates that no cryptocurrencies were found.
    /// </summary>
    NoCryptocurrenciesFound,

    #endregion

    #region User events
    /// <summary>
    /// Indicates an attempt to add a null user.
    /// </summary>
    NullUser = 200,

    /// <summary>
    /// Indicates that a user with a specified ID was not found.
    /// </summary>
    UserNotFound,

    /// <summary>
    /// Indicates that a new user was added.
    /// </summary>
    UserAdded,

    /// <summary>
    /// Indicates that a user was updated.
    /// </summary>
    UserUpdated,

    /// <summary>
    /// Indicates that a user was deleted.
    /// </summary>
    UserDeleted,

    /// <summary>
    /// Indicates the start of the process to retrieve all users.
    /// </summary>
    GetAllUsersStarted,

    /// <summary>
    /// Indicates the successful completion of the process to retrieve all users.
    /// </summary>
    GetAllUsersCompleted,

    /// <summary>
    /// Indicates that no users were found during the retrieval process.
    /// </summary>
    NoUsersFound,

    #endregion

    #region TransactionHistory events
    /// <summary>
    /// Indicates an attempt to add a null transaction history.
    /// </summary>
    NullTransactionHistory = 300,

    /// <summary>
    /// Indicates that a transaction history with a specified ID was not found.
    /// </summary>
    TransactionHistoryNotFound,

    /// <summary>
    /// Indicates that a new transaction history was added.
    /// </summary>
    TransactionHistoryAdded,

    /// <summary>
    /// Indicates that a transaction history was updated.
    /// </summary>
    TransactionHistoryUpdated,

    /// <summary>
    /// Indicates that a transaction history was deleted.
    /// </summary>
    TransactionHistoryDeleted,

    /// <summary>
    /// Indicates the start of retrieving all transaction histories.
    /// </summary>
    GetAllTransactionHistoriesStarted,

    /// <summary>
    /// Indicates the successful retrieval of all transaction histories.
    /// </summary>
    GetAllTransactionHistoriesCompleted,

    /// <summary>
    /// Indicates that no transaction histories were found.
    /// </summary>
    NoTransactionHistoriesFound,
    #endregion

    #region General events
    /// <summary>
    /// Indicates an error occurred while accessing the database.
    /// </summary>
    DatabaseError = 900,

    /// <summary>
    /// Indicates an error occurred while accessing an external API.
    /// </summary>
    ExternalApiError,

    /// <summary>
    /// Indicates an unexpected error occurred.
    /// </summary>
    UnexpectedError
    #endregion
}
