using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class QuizVraagAntwoorden
    {
        internal QuizVraag vraag;
        internal bool goed;

        internal QuizVraagAntwoorden(QuizVraag vraag)
        {
            this.vraag = vraag;
            goed = false;
        }
    }
}
