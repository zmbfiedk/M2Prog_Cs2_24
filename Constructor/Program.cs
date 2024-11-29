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
            QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt de antwoord");
            Quiz quiz = new Quiz(10);
        }
    }
}
