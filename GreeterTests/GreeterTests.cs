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

            Assert.Equal("Hello, Bob.".Trim(), result.Trim());
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

        [Fact]
        public void Greet_ShouldReturnGreetingWithMultipleNames_WhenMoreThanTwoNamesAreProvided()
        {
            var greeter = new Greeter();

            var result = greeter.Greet("Amy, Brian, Charlotte");

            Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
        }

        [Fact]
        public void Greet_ShouldReturnSeparateGreetingsForNormalAndShoutedNames_WhenBothAreProvided()
        {
            var greeter = new Greeter();

            var result = greeter.Greet("Amy, BRIAN, Charlotte");

            Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", result);
        }

        [Fact]
        public void Greet_NamesWithComma_ReturnsCorrectGreeting()
        {
            var greeter = new Greeter();
            string name = "Bob, Charlie, Dianne";

            var result = greeter.Greet(name);

            Assert.Equal("Hello, Bob, Charlie, and Dianne.", result);
        }
    }
}