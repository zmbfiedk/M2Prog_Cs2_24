using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Constructor
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoorden[] ingevuldeAntwoorden;

        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoorden[aantalVragen];
        }

        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
            VoegVraagToeOpIndex(index, nieuweVraag);
        }

        internal void StelVraag(int vraagIndex)
        {
            QuizVraag vraag = vragen[vraagIndex];

            Console.WriteLine(vraag.vraag);
            string gegevenAntwoord = Console.ReadLine();

            bool isJuist = gegevenAntwoord.Equals(vraag.antwoord, StringComparison.OrdinalIgnoreCase);

            QuizVraagAntwoorden antwoord = new QuizVraagAntwoorden(vraag)
            {
                goed = isJuist
            };
            ingevuldeAntwoorden[vraagIndex] = antwoord;

            if (isJuist)
            {
                Console.WriteLine("Correct! Goed gedaan.");
            }
            else
            {
                Console.WriteLine($"Fout! Het juiste antwoord was: {vraag.antwoord}");
            }
        }

        internal int BerekenScore()
        {
            int score = 0;
            foreach (var antwoord in ingevuldeAntwoorden)
            {
                if (antwoord != null && antwoord.goed)
                {
                    score++;
                }
            }
            return score;
        }
    }
}
