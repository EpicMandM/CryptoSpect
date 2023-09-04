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
        LoggerMessage.Define(LogLevel.Warning, new EventId(1, "Null Cryptocurrency"), "Attempted to add a null cryptocurrency.");

    /// <summary>
    /// Event indicating a cryptocurrency with a specific ID was not found.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyNotFound =
        LoggerMessage.Define<string>(LogLevel.Warning, new EventId(2, "Cryptocurrency Not Found"), "Cryptocurrency with ID '{Id}' was not found.");

    /// <summary>
    /// Event indicating a new cryptocurrency was added.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyAdded =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId(3, "Cryptocurrency Added"), "A new cryptocurrency with ID '{Id}' was added.");

    /// <summary>
    /// Event indicating a cryptocurrency was updated.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyUpdated =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId(4, "Cryptocurrency Updated"), "A new cryptocurrency with ID '{Id}' was updated.");

    /// <summary>
    /// Event indicating a cryptocurrency was deleted.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogCryptocurrencyDeleted =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId(5, "Cryptocurrency Deleted"), "A new cryptocurrency with ID '{Id}' was deleted.");

    /// <summary>
    /// Event indicating the start of the process to retrieve all cryptocurrencies.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogGetAllCryptocurrenciesStarted =
        LoggerMessage.Define(LogLevel.Information, new EventId(6, "GetAllCryptocurrenciesStarted"), "Started retrieving all cryptocurrencies.");

    /// <summary>
    /// Event indicating the successful completion of the process to retrieve all cryptocurrencies.
    /// </summary>
    public static readonly Action<ILogger, int, Exception?> LogGetAllCryptocurrenciesCompleted =
        LoggerMessage.Define<int>(LogLevel.Information, new EventId(7, "GetAllCryptocurrenciesCompleted"), "Successfully retrieved {Count} cryptocurrencies.");

    /// <summary>
    /// Event indicating that no cryptocurrencies were found.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNoCryptocurrenciesFound =
        LoggerMessage.Define(LogLevel.Warning, new EventId(8, "NoCryptocurrenciesFound"), "No cryptocurrencies found.");

    #endregion

    #region User events

    /// <summary>
    /// Event indicating an attempt to add a null user.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNullUser =
            LoggerMessage.Define(LogLevel.Warning, new EventId(6, "Null User"), "Attempted to add a null user.");

    /// <summary>
    /// Event indicating a user with a specific ID was not found.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogUserNotFound =
        LoggerMessage.Define<string>(LogLevel.Warning, new EventId(7, "User Not Found"), "User with ID '{Id}' was not found.");

    /// <summary>
    /// Event indicating a new user was added.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogUserAdded =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId(8, "User Added"), "A new user with ID '{Id}' was added.");

    /// <summary>
    /// Event indicating a user was updated.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogUserUpdated =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId(9, "User Updated"), "A user with ID '{Id}' was updated.");

    /// <summary>
    /// Event indicating a user was deleted.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogUserDeleted =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId(10, "User Deleted"), "A user with ID '{Id}' was deleted.");

    #endregion

    #region TransactionHistory events

    /// <summary>
    /// Event indicating an attempt to add a null transaction history.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogNullTransactionHistory =
        LoggerMessage.Define(LogLevel.Warning, new EventId(9, "Null TransactionHistory"), "Attempted to add a null transaction history.");

    /// <summary>
    /// Event indicating a transaction history with a specific ID was not found.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryNotFound =
        LoggerMessage.Define<Guid>(LogLevel.Warning, new EventId(10, "TransactionHistory Not Found"), "TransactionHistory with ID '{Id}' was not found.");

    /// <summary>
    /// Event indicating a new transaction history was added.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryAdded =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId(11, "TransactionHistory Added"), "A new transaction history with ID '{Id}' was added.");

    /// <summary>
    /// Event indicating a transaction history was updated.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryUpdated =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId(12, "TransactionHistory Updated"), "A transaction history with ID '{Id}' was updated.");

    /// <summary>
    /// Event indicating a transaction history was deleted.
    /// </summary>
    public static readonly Action<ILogger, Guid, Exception?> LogTransactionHistoryDeleted =
        LoggerMessage.Define<Guid>(LogLevel.Information, new EventId(13, "TransactionHistory Deleted"), "A transaction history with ID '{Id}' was deleted.");

    #endregion

    #region General events

    /// <summary>
    /// Event indicating an error occurred while accessing the database.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogDatabaseError =
        LoggerMessage.Define(LogLevel.Error, new EventId(14, "Database Error"), "An error occurred while accessing the database.");

    /// <summary>
    /// Event indicating an error occurred while accessing an external API.
    /// </summary>
    public static readonly Action<ILogger, string, Exception?> LogExternalApiError =
        LoggerMessage.Define<string>(LogLevel.Error, new EventId(15, "External API Error"), "An error occurred while accessing the external API: '{ApiName}'.");

    /// <summary>
    /// Event indicating an unexpected error occurred.
    /// </summary>
    public static readonly Action<ILogger, Exception?> LogUnexpectedError =
        LoggerMessage.Define(LogLevel.Critical, new EventId(16, "Unexpected Error"), "An unexpected error occurred.");
    #endregion
}
