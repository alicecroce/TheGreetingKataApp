using TheGreetingKataApp;

namespace GreeterTests
{
    public class GreeterTests
    {
        [Fact]
        public void Greet_SingleName_ReturnsGreeting()
        {
            // Arrange
            var greeter = new Greeter();
            string name = "Bob";

            // Act
            var result = greeter.Greet(name);

            // Assert
            Assert.Equal("Hello, Bob.", result);
        }
    }
}