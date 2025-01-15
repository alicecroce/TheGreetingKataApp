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

            if (name.Contains(",")) // Requirement 4
            {
                var names = name.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (names.Length == 2)
                {
                    return $"Hello, {names[0].Trim()} and {names[1].Trim()}.";
                }
            }

            return $"Hello, {name}."; // Requirement 1
        }
    }
}
