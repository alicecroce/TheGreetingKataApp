namespace TheGreetingKataApp
{
    public class Greeter
    {
        public string Greet(string name)
        {
            if (name == null) // Requirement 2
            {
                return "Hello, my friend.";
            }

            if (name.ToUpper() == name) // Requirement 3
            {
                return $"HELLO {name}!";
            }

            return $"Hello, {name}."; // Requirement 1
        }
    }
}
