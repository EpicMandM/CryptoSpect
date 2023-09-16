using CryptoSpect.Core.Interfaces;
using CryptoSpect.Core.Models;
using CryptoSpect.Service.Implementations;
using CryptoSpect.Service.Interfaces;
using NSubstitute;

namespace CryptoSpect.Test;

/// <summary>
/// Contains unit tests for the UserService class.
/// </summary>
public sealed class UserServiceTests
{
    /// <summary>
    /// Mock of the IUserRepository interface.
    /// </summary>
    private readonly IUserRepository _mockUserRepository;

    /// <summary>
    /// Instance of the IUserService being tested.
    /// </summary>
    private readonly IUserService _UserService;

    /// <summary>
    /// Initializes a new instance of the UserServiceTests class.
    /// </summary>
    public UserServiceTests()
    {
        _mockUserRepository = Substitute.For<IUserRepository>();
        _UserService = new UserService(_mockUserRepository);
    }

    /// <summary>
    /// Tests that the AddAsync method of the UserService class calls the AddAsync method of the repository when a valid User is provided.
    /// </summary>
    [Fact]
    public async Task AddAsyncShouldCallRepositoryAddAsyncWhenValidUserIsProvidedAsync()
    {
        // Arrange
        var User = new User(Guid.NewGuid(), "Username", "email@email.com", "passwordHash", DateTimeOffset.UtcNow);

        // Act
        await _UserService.AddAsync(User).ConfigureAwait(false);

        // Assert
        await _mockUserRepository.Received(1).AddAsync(User).ConfigureAwait(false);
    }

    /// <summary>
    /// Tests that the GetByIdAsync method of the UserService class returns the expected User when a valid ID is provided.
    /// </summary>
    [Fact]
    public async Task GetByIdAsyncShouldReturnUserWhenValidIdIsProvidedAsync()
    {
        // Arrange
        var id = Guid.NewGuid();
        var User = new User(id, "Username", "email@email.com", "passwordHash", DateTimeOffset.UtcNow);
        _mockUserRepository.GetByIdAsync(id).Returns(User);

        // Act
        var result = await _UserService.GetByIdAsync(id).ConfigureAwait(false);

        // Assert
        Assert.Equal(User, result);
    }

    /// <summary>
    /// Tests that the DeleteAsync method of the UserService class deletes the User when provided with a valid ID.
    /// </summary>
    [Fact]
    public async Task DeleteAsyncWithValidIdDeletesUser()
    {
        // Arrange
        var validId = Guid.NewGuid();
        _mockUserRepository.DeleteAsync(validId).Returns(Task.CompletedTask);

        // Act
        await _UserService.DeleteAsync(validId).ConfigureAwait(false);

        // Assert
        await _mockUserRepository.Received().DeleteAsync(validId).ConfigureAwait(false);
    }

    /// <summary>
    /// Tests that the GetAllAsync method of the UserService class returns all cryptocurrencies when they exist.
    /// </summary>
    [Fact]
    public async Task GetAllAsyncWithExistingCryptocurrenciesReturnsAll()
    {
        // Arrange
        var cryptocurrencies = new List<User>
        {
            new User(Guid.NewGuid(), "Username1", "email1@email.com", "passwordHash1", DateTimeOffset.UtcNow),
            new User(Guid.NewGuid(), "Username2", "email2@email.com", "passwordHash2", DateTimeOffset.UtcNow)
        };
        _mockUserRepository.GetAllAsync().Returns(cryptocurrencies);

        // Act
        var result = await _UserService.GetAllAsync().ConfigureAwait(false);

        // Assert
        Assert.Equal(cryptocurrencies, result);
    }
    /// <summary>
    /// Tests that the GetAllAsync method of the UserService class returns an empty list when no cryptocurrencies exist.
    /// </summary>
    [Fact]
    public async Task GetAllAsyncWithNoCryptocurrenciesReturnsEmptyList()
    {
        // Arrange
        _mockUserRepository.GetAllAsync().Returns(new List<User>());

        // Act
        var result = await _UserService.GetAllAsync().ConfigureAwait(false);

        // Assert
        Assert.Empty(result);

    }

    /// <summary>
    /// Tests that the UpdateAsync method of the UserService class updates the User when provided with a valid User.
    /// </summary>
    [Fact]
    public async Task UpdateAsyncWithValidUserUpdatesUser()
    {
        // Arrange
        var UserToUpdate = new User(Guid.NewGuid(), "Username", "email@email.com", "passwordHash", DateTimeOffset.UtcNow);
        _mockUserRepository.UpdateAsync(UserToUpdate).Returns(Task.CompletedTask);

        // Act
        await _mockUserRepository.UpdateAsync(UserToUpdate).ConfigureAwait(false);

        // Assert
        await _mockUserRepository.Received().UpdateAsync(UserToUpdate).ConfigureAwait(false);
    }
}
