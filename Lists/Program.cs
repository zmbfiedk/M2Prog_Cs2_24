namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            List<string> characterList = new List<string>();
            characterList.Add("Sleepy joe");

            string[] characters = {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
            };

            foreach (string character in characters)
            {
                characterList.Add(character);
            }

            Console.WriteLine("Character List:");
            foreach (string character in characterList)
            {
                Console.WriteLine(character);
            }
        }
    }
}
