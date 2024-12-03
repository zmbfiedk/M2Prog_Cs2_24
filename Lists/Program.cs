using System.Security.Cryptography.X509Certificates;

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

            List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };

            reviews.Remove(342.97);

            Console.WriteLine("Removing the second item from characterList...");
            characterList.RemoveAt(1);

            Console.WriteLine("Removing the second item from reviews...");
            reviews.RemoveAt(1);

            Console.WriteLine("\nCharacter List:");
            foreach (string character in characterList)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("\nReviews:");
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }
        }
    }
}
