using TheGreetingKataApp;

namespace GreeterTests
{
    public class GreeterTests
    {
        [Fact]
        public void Greet_SingleName_ReturnsGreeting()
        {
            var greeter = new Greeter();
            string name = "Bob";

            var result = greeter.Greet(name);

            Assert.Equal("Hello, Bob.", result);
        }

        [Fact]
        public void Greet_NullName_ReturnsFriendGreeting()
        {
            var greeter = new Greeter();
            string name = null;

            var result = greeter.Greet(name);

            Assert.Equal("Hello, my friend.", result);
        }

        [Fact]
        public void Greet_ShouldReturnShoutedGreeting_WhenNameIsAllUppercase()
        {
            var greeter = new Greeter();

            var result = greeter.Greet("JERRY");

            Assert.Equal("HELLO JERRY!", result);
        }

        [Fact]
        public void Greet_ShouldReturnGreetingWithTwoNames_WhenTwoNamesAreProvided()
        {
            var greeter = new Greeter();

            var result = greeter.Greet("Jill, Jane");

            Assert.Equal("Hello, Jill and Jane.", result);
        }


    }
}