namespace CryptoSpect.DA.Exceptions;

/// <summary>
/// Represents errors that occur within the service layer.
/// </summary>
public sealed class ServiceException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public ServiceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceException"/> class.
    /// </summary>
    public ServiceException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public ServiceException(string message) : base(message)
    {
    }
}
