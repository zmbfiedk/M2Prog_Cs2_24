using System;
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

            List<Pickup> pickups = new List<Pickup>();

            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0
                };
                pickups.Add(pickup);
            }

            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                if (pickups[i].x == 4)
                {
                    pickups.RemoveAt(i);
                }
            }

            List<mob> mobs = new List<mob>();
            mobs.Add(new mob(10));
            mobs.Add(new mob(10));
            mobs.Add(new mob(10));


            Random rand = new Random();
            for (int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(i);


                foreach (var mob in mobs)
                {
                    int randomValue = rand.Next(0, 100);
                    if (randomValue < 30)
                    {
                        mob.TakeDamage(1);
                        System.Console.WriteLine($"Mob heeft 1 schade ontvangen. Nieuwe HP: {mob.hp}");
                    }

                }
                List<mob> defeated = mobs.Where(mob => mob.isdead).ToList();
                foreach (var deadMob in defeated)
                {
                    Console.WriteLine($"Mob met HP: {deadMob.hp} is dood.");
                }
                mobs.RemoveAll(mob => mob.isdead);
                if (mobs.Count == 0)
                {
                    break;
                }
            }




            Console.WriteLine("Remaining Pickups:");
            foreach (Pickup pickup in pickups)
            {
                Console.WriteLine($"Pickup - x: {pickup.x}, y: {pickup.y}");
            }

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

