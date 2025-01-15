namespace TheGreetingKataApp
{
    public class Greeter
    {
        public string Greet(string name)
        {
            // Requirement 2: Handle the case when name is null
            if (name == null)
            {
                return "Hello, my friend.";
            }
            // Requirement 3: Handle the case when name is in uppercase (shouted)
            if (name.ToUpper() == name)
            {
                return $"HELLO {name}!";
            }

            // Requirement 6 & 8: Handle commas and quotes, and escape them correctly
            var namesList = new List<string>();
            var tempName = string.Empty;
            var insideQuotes = false;

            foreach (var c in name)
            {
                if (c == '"')
                {
                    insideQuotes = !insideQuotes;
                }
                else if (c == ',' && !insideQuotes)
                {
                    namesList.Add(tempName.Trim());
                    tempName = string.Empty;
                }
                else
                {
                    tempName += c;
                }
            }

            if (!string.IsNullOrEmpty(tempName))
            {
                namesList.Add(tempName.Trim());
            }

            var normalNames = namesList.Where(n => n != n.ToUpper()).ToList();
            var shoutedNames = namesList.Where(n => n == n.ToUpper()).ToList();

            string greeting = "";

            // Requirement 1: Greet based on the number of normal names
            if (normalNames.Count > 0)
            {
                if (normalNames.Count == 1)
                {
                    greeting += $"Hello, {normalNames[0]}.";
                }
                else if (normalNames.Count == 2)
                {
                    greeting += $"Hello, {normalNames[0]} and {normalNames[1]}.";
                }
                else
                {
                    string formattedNames = string.Join(", ", normalNames.Take(normalNames.Count - 1));
                    greeting += $"Hello, {formattedNames}, and {normalNames.Last()}.";
                }
            }

            // Requirement 6 (continued): Greet shouted names (all uppercase)
            if (shoutedNames.Count > 0)
            {
                if (normalNames.Count > 0)
                {
                    greeting += " ";
                }
                greeting += $"AND HELLO {string.Join(" AND ", shoutedNames)}!";
            }

            // Requirement 1 (continued): Default greeting if no names provided
            return string.IsNullOrEmpty(greeting) ? $"Hello, {name}." : greeting;
        }

    }
}
