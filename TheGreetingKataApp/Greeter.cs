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

            // Requirement 6/7
            var namesList = name.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(n => n.Trim())
                                 .ToList();

            //Requirement 7
            List<string> allNames = new List<string>();

            foreach (var n in namesList)
            {
                if (n.Contains(","))
                {
                    var splitNames = n.Split(',').Select(n => n.Trim()).ToList();
                    allNames.AddRange(splitNames);
                }
                else
                {
                    allNames.Add(n);
                }
            }

            //Requirement 6
            var normalNames = namesList.Where(n => n != n.ToUpper()).ToList();
            var shoutedNames = namesList.Where(n => n == n.ToUpper()).ToList();

            string greeting = "";

            // Requirement 1 (modificato)
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

            // Requirement 6 (ulteriore gestione per i nomi urlati)
            if (shoutedNames.Count > 0)
            {
                if (normalNames.Count > 0)
                {
                    greeting += " ";
                }
                greeting += $"AND HELLO {string.Join(" AND ", shoutedNames)}!";
            }

            // Requirement 1 (saluto di base modificato)
            return string.IsNullOrEmpty(greeting) ? $"Hello, {name}." : greeting;
        }
    }
}