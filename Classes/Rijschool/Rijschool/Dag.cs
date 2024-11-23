using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rijschool
{
    internal class Dag
    {
        internal DateTime Datum;
        internal LesUur[] LesUren;
        public List<LesUur> lesUren { get; set; } = new List<LesUur>();
    }
}
