using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DemoUnitTest.Models;
using DemoUnitTest.Repositories;
using DemoUnitTest.Services;
namespace DemoUnitTest
{
[TestClass]
public class UserServiceTests
{
    private Mock<IUserRepository> _mockUserRepository;
    private IUserService _userService;

    [TestInitialize]
    public void Setup()
    {
        _mockUserRepository = new Mock<IUserRepository>();
        _userService = new UserService(_mockUserRepository.Object);
    }

    [TestMethod]
    public void GetUserById_ShouldReturnUser()
    {
        // Arrange
        var userId = 1;
        var user = new User { Id = userId, Name = "John Doe" };
        _mockUserRepository.Setup(repo => repo.GetById(userId)).Returns(user);

        // Act
        var result = _userService.GetUserById(userId);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(userId, result.Id);
        Assert.AreEqual("John Doe!", result.Name);
    }

    [TestMethod]
    public void GetUserById_ShouldCallRepositoryOnce()
    {
        // Arrange
        var userId = 1;
        _mockUserRepository.Setup(repo => repo.GetById(userId)).Returns(new User { Id = userId, Name = "John Doe" });

        // Act
        _userService.GetUserById(userId);

        // Assert
        _mockUserRepository.Verify(repo => repo.GetById(userId), Times.Once);
    }
}
}