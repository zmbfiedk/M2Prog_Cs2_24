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
    }

    
        
}
