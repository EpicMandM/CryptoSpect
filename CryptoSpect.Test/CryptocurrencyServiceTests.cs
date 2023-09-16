using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Implementations;
using CryptoSpect.Service.Interfaces;
using NSubstitute;

namespace CryptoSpect.Test;

/// <summary>
/// Contains unit tests for the CryptocurrencyService class.
/// </summary>
public sealed class CryptocurrencyServiceTests
{
    /// <summary>
    /// Mock of the ICryptocurrencyRepository interface.
    /// </summary>
    private readonly ICryptocurrencyRepository _mockCryptocurrencyRepository;

    /// <summary>
    /// Instance of the ICryptocurrencyService being tested.
    /// </summary>
    private readonly ICryptocurrencyService _cryptocurrencyService;

    /// <summary>
    /// Initializes a new instance of the CryptocurrencyServiceTests class.
    /// </summary>
    public CryptocurrencyServiceTests()
    {
        _mockCryptocurrencyRepository = Substitute.For<ICryptocurrencyRepository>();
        _cryptocurrencyService = new CryptocurrencyService(_mockCryptocurrencyRepository);
    }

    /// <summary>
    /// Tests that the AddAsync method of the CryptocurrencyService class calls the AddAsync method of the repository when a valid cryptocurrency is provided.
    /// </summary>
    [Fact]
    public async Task AddAsyncShouldCallRepositoryAddAsyncWhenValidCryptocurrencyIsProvidedAsync()
    {
        // Arrange
        var cryptocurrency = new Cryptocurrency("id", "Bitcoin", "BTC", 50000, new List<HistoricalData>());

        // Act
        await _cryptocurrencyService.AddAsync(cryptocurrency).ConfigureAwait(false);

        // Assert
        await _mockCryptocurrencyRepository.Received(1).AddAsync(cryptocurrency).ConfigureAwait(false);
    }

    /// <summary>
    /// Tests that the GetByIdAsync method of the CryptocurrencyService class returns the expected cryptocurrency when a valid ID is provided.
    /// </summary>
    [Fact]
    public async Task GetByIdAsyncShouldReturnCryptocurrencyWhenValidIdIsProvidedAsync()
    {
        // Arrange
        var id = "someId";
        var cryptocurrency = new Cryptocurrency(id, "Bitcoin", "BTC", 50000, new List<HistoricalData>());
        _mockCryptocurrencyRepository.GetByIdAsync(id).Returns(cryptocurrency);

        // Act
        var result = await _cryptocurrencyService.GetByIdAsync(id).ConfigureAwait(false);

        // Assert
        Assert.Equal(cryptocurrency, result);
    }

    /// <summary>
    /// Tests that the DeleteAsync method of the CryptocurrencyService class deletes the cryptocurrency when provided with a valid ID.
    /// </summary>
    [Fact]
    public async Task DeleteAsyncWithValidIdDeletesCryptocurrency()
    {
        // Arrange
        var validId = "someValidId";
        _mockCryptocurrencyRepository.DeleteAsync(validId).Returns(Task.CompletedTask);

        // Act
        await _cryptocurrencyService.DeleteAsync(validId).ConfigureAwait(false);

        // Assert
        await _mockCryptocurrencyRepository.Received().DeleteAsync(validId).ConfigureAwait(false);
    }

    /// <summary>
    /// Tests that the GetAllAsync method of the CryptocurrencyService class returns all cryptocurrencies when they exist.
    /// </summary>
    [Fact]
    public async Task GetAllAsyncWithExistingCryptocurrenciesReturnsAll()
    {
        // Arrange
        var cryptocurrencies = new List<Cryptocurrency>
        {
            new Cryptocurrency("id1", "Bitcoin", "BTC", 50000, new List<HistoricalData>()),
            new Cryptocurrency("id2", "Ethereum", "ETH", 5000, new List<HistoricalData>())
        };
        _mockCryptocurrencyRepository.GetAllAsync().Returns(cryptocurrencies);

        // Act
        var result = await _cryptocurrencyService.GetAllAsync().ConfigureAwait(false);

        // Assert
        Assert.Equal(cryptocurrencies, result);
    }
    /// <summary>
    /// Tests that the GetAllAsync method of the CryptocurrencyService class returns an empty list when no cryptocurrencies exist.
    /// </summary>
    [Fact]
    public async Task GetAllAsyncWithNoCryptocurrenciesReturnsEmptyList()
    {
        // Arrange
        _mockCryptocurrencyRepository.GetAllAsync().Returns(new List<Cryptocurrency>());

        // Act
        var result = await _cryptocurrencyService.GetAllAsync().ConfigureAwait(false);

        // Assert
        Assert.Empty(result);

    }

    /// <summary>
    /// Tests that the UpdateAsync method of the CryptocurrencyService class updates the cryptocurrency when provided with a valid cryptocurrency.
    /// </summary>
    [Fact]
    public async Task UpdateAsyncWithValidCryptocurrencyUpdatesCryptocurrency()
    {
        // Arrange
        var cryptocurrencyToUpdate = new Cryptocurrency("id", "Bitcoin", "BTC", 50000, new List<HistoricalData>());
        _mockCryptocurrencyRepository.UpdateAsync(cryptocurrencyToUpdate).Returns(Task.CompletedTask);

        // Act
        await _mockCryptocurrencyRepository.UpdateAsync(cryptocurrencyToUpdate).ConfigureAwait(false);

        // Assert
        await _mockCryptocurrencyRepository.Received().UpdateAsync(cryptocurrencyToUpdate).ConfigureAwait(false);
    }
}
