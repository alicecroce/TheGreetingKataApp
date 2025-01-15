namespace TheGreetingKataApp
{
    public class Greeter
    {
        public string Greet(string name)
        {
            if (name == null)
            {
                return "Hello, my friend.";
            }

            return $"Hello, {name}.";
        }
    }
}
