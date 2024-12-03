namespace Constructor
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
            
            Quiz quiz = new Quiz(5);

            quiz.VoegVraagToeOpIndex(0, "Wat is de hoofdstad van Nederland?", "Amsterdam");
            quiz.VoegVraagToeOpIndex(1, "Hoeveel planeten zijn er in ons zonnestelsel?", "8");
            quiz.VoegVraagToeOpIndex(2, "Welke kleur krijg je door blauw en geel te mengen?", "Groen");
            quiz.VoegVraagToeOpIndex(3, "Hoeveel dagen heeft een schrikkeljaar?", "366");
            quiz.VoegVraagToeOpIndex(4, "Wat is het grootste continent op aarde?", "Azië");

            for (int i = 0; i < quiz.vragen.Length; i++)
            {
                if (quiz.vragen[i] != null)
                {
                    quiz.StelVraag(i);
                }
            }

            int score = quiz.BerekenScore();
            Console.WriteLine($"\nJe eindscore is: {score}/{quiz.vragen.Length}");
        }
    }
}
