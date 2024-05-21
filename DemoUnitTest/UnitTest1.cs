namespace DemoUnitTest;

[TestClass]
public class UnitTest1
{
    [TestClass]
    public class MyServiceTests
    {
        [TestMethod]
        public void AddNumbers_ShouldReturnCorrectSum()
        {
            // Arrange
            var service = new MyService();
            int a = 5;
            int b = 3;

            // Act
            var result = service.AddNumbers(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }
    }

    public class MyService
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}