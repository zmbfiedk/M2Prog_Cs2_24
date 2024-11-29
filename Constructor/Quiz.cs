using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal  void VoegVraagToeOpIndex(int index , QuizVraag vraag)
        {
           vragen[index] = vraag;  
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
            VoegVraagToeOpIndex(index, nieuweVraag);
        }

        internal void StelVraaag(int vraagIndex)
        {
            QuizVraag vraag = vragen[Index];
        }
    }

    
        
}
