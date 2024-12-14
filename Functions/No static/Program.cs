using System.Reflection;

namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan?",
            "how old are you?",
            "how much sleep do you get?",
            "How long do you think you'd survive in a zombie apocalypse?",
            "What secret conspiracy would you like to actually start letting other people know?",
            "In July 2023, video game company EA announced that players will be able to explore Wakanda in an upcoming open-world video game based on the adventures of what Marvel superhero?\r\n",
            "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?"
        };

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            string vraag0 = GetVraag(0);
            Console.WriteLine($"Example vraag: {vraag0}");

            string randomVraag = GetRandomVraag();
            Console.WriteLine($"Random vraag: {randomVraag}");

            Console.WriteLine("Random Questions with Answers:");
            for (int i = 0; i < 4; i++)
            {
                AskRandomQuestion();
            }
        }

        internal void AskQuestions()
        {
            vraag1();
            vraag2();
            vraag3();
            vraag4();
            vraag5();
        }

        internal void vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal void vraag2()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal void vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal void vraag4()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal void vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal string vraag6()
        {
            Console.WriteLine("Have you ever tried talking to an animal?");
            string antwoord = Console.ReadLine();

            return antwoord;
        }

        internal string GetVraag(int vraagIndex)
        {
            if (vraagIndex < 0 || vraagIndex >= vragen.Length)
                throw new IndexOutOfRangeException("Invalid question index.");
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, vragen.Length);
            return GetVraag(randomIndex);
        }

        internal void AskRandomQuestion()
        {
            string randomVraag = GetRandomVraag();
            Console.WriteLine($"Vraag: {randomVraag}");
            Console.Write("Antwoord: ");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Je antwoord was: {antwoord}");
        }
    }
}
