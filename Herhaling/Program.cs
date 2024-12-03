namespace Herhaling
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
            double[] prijzen = new double[] { 0.99, 5.60, 10.10,15.00 };

            string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu","big lunch menu"};

            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "prijzijg maar lekker",
                Sterren = 5
            };

            formulieren[1] = new Formulier()
            {
                Feedback = "gwn lekker",
                Sterren = 5
            };

            for (int i = 0; i < prijzen.Length; i++) 
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artiekelen[i]);
            }

            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
            }


        }

 
        
     
    }
}
