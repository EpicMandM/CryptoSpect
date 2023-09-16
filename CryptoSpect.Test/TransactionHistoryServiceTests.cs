using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Implementations;
using CryptoSpect.Service.Interfaces;
using NSubstitute;

namespace CryptoSpect.Test;

/// <summary>
/// Contains unit tests for the TransactionHistoryService class.
/// </summary>
public sealed class TransactionHistoryServiceTests
{
    /// <summary>
    /// Mock of the ITransactionHistoryRepository interface.
    /// </summary>
    private readonly ITransactionHistoryRepository _mockTransactionHistoryRepository;

    /// <summary>
    /// Instance of the ITransactionHistoryService being tested.
    /// </summary>
    private readonly ITransactionHistoryService _TransactionHistoryService;

    /// <summary>
    /// Initializes a new instance of the TransactionHistoryServiceTests class.
    /// </summary>
    public TransactionHistoryServiceTests()
    {
        _mockTransactionHistoryRepository = Substitute.For<ITransactionHistoryRepository>();
        _TransactionHistoryService = new TransactionHistoryService(_mockTransactionHistoryRepository);
    }

    /// <summary>
    /// Tests that the AddAsync method of the TransactionHistoryService class calls the AddAsync method of the repository when a valid TransactionHistory is provided.
    /// </summary>
    [Fact]
    public async Task AddAsyncShouldCallRepositoryAddAsyncWhenValidTransactionHistoryIsProvidedAsync()
    {
        // Arrange
        var TransactionHistory = new TransactionHistory(Guid.NewGuid(), "someCryptocurrencyId", "someTransactionType", 1, DateTimeOffset.UtcNow);

        // Act
        await _TransactionHistoryService.AddAsync(TransactionHistory).ConfigureAwait(false);

        // Assert
        await _mockTransactionHistoryRepository.Received(1).AddAsync(TransactionHistory).ConfigureAwait(false);
    }

    /// <summary>
    /// Tests that the GetByIdAsync method of the TransactionHistoryService class returns the expected TransactionHistory when a valid ID is provided.
    /// </summary>
    [Fact]
    public async Task GetByIdAsyncShouldReturnTransactionHistoryWhenValidIdIsProvidedAsync()
    {
        // Arrange
        var id = Guid.NewGuid();
        var TransactionHistory = new TransactionHistory(id, "someCryptocurrencyId", "someTransactionTy pe", 1, DateTimeOffset.UtcNow);
        _mockTransactionHistoryRepository.GetByIdAsync(id).Returns(TransactionHistory);

        // Act
        var result = await _TransactionHistoryService.GetByIdAsync(id).ConfigureAwait(false);

        // Assert
        Assert.Equal(TransactionHistory, result);
    }

    /// <summary>
    /// Tests that the DeleteAsync method of the TransactionHistoryService class deletes the TransactionHistory when provided with a valid ID.
    /// </summary>
    [Fact]
    public async Task DeleteAsyncWithValidIdDeletesTransactionHistory()
    {
        // Arrange
        var validId = Guid.NewGuid();
        _mockTransactionHistoryRepository.DeleteAsync(validId).Returns(Task.CompletedTask);

        // Act
        await _TransactionHistoryService.DeleteAsync(validId).ConfigureAwait(false);

        // Assert
        await _mockTransactionHistoryRepository.Received().DeleteAsync(validId).ConfigureAwait(false);
    }

    /// <summary>
    /// Tests that the GetAllAsync method of the TransactionHistoryService class returns all cryptocurrencies when they exist.
    /// </summary>
    [Fact]
    public async Task GetAllAsyncWithExistingCryptocurrenciesReturnsAll()
    {
        // Arrange
        var cryptocurrencies = new List<TransactionHistory>
        {
            new TransactionHistory(Guid.NewGuid(), "someCryptocurrencyId1", "someTransactionType1", 50000, DateTimeOffset.UtcNow),
            new TransactionHistory(Guid.NewGuid(), "someCryptocurrencyId2", "someTransactionType2", 5000, DateTimeOffset.UtcNow)
        };
        _mockTransactionHistoryRepository.GetAllAsync().Returns(cryptocurrencies);

        // Act
        var result = await _TransactionHistoryService.GetAllAsync().ConfigureAwait(false);

        // Assert
        Assert.Equal(cryptocurrencies, result);
    }
    /// <summary>
    /// Tests that the GetAllAsync method of the TransactionHistoryService class returns an empty list when no cryptocurrencies exist.
    /// </summary>
    [Fact]
    public async Task GetAllAsyncWithNoCryptocurrenciesReturnsEmptyList()
    {
        // Arrange
        _mockTransactionHistoryRepository.GetAllAsync().Returns(new List<TransactionHistory>());

        // Act
        var result = await _TransactionHistoryService.GetAllAsync().ConfigureAwait(false);

        // Assert
        Assert.Empty(result);

    }

    /// <summary>
    /// Tests that the UpdateAsync method of the TransactionHistoryService class updates the TransactionHistory when provided with a valid TransactionHistory.
    /// </summary>
    [Fact]
    public async Task UpdateAsyncWithValidTransactionHistoryUpdatesTransactionHistory()
    {
        // Arrange
        var TransactionHistoryToUpdate = new TransactionHistory(Guid.NewGuid(), "someCryptocurrencyId", "someTransactionType", 1, DateTimeOffset.UtcNow);
        _mockTransactionHistoryRepository.UpdateAsync(TransactionHistoryToUpdate).Returns(Task.CompletedTask);

        // Act
        await _mockTransactionHistoryRepository.UpdateAsync(TransactionHistoryToUpdate).ConfigureAwait(false);

        // Assert
        await _mockTransactionHistoryRepository.Received().UpdateAsync(TransactionHistoryToUpdate).ConfigureAwait(false);
    }
}
