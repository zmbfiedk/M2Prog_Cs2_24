using System.Runtime.InteropServices;

namespace Rijschool
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Auto auto1 = new Auto()
            {
                Automaat = true,
                Kenteken = "AA824H",
                Kilometerstand = 20567,
                Merk = "Volkswagen"
            };

            Auto auto2 = new Auto()
            {
                Automaat = false,
                Kenteken = "KU786G",
                Kilometerstand = 65739,
                Merk = "Volvo"
            };

            Rijleraar rijleraar = new Rijleraar()
            {
                Leeftijd = 30,
                Naam = "John",
                Zzp = false
            };

            LesUur lesUur = new LesUur()
            {
                Auto = auto1,
                Rijleraar = rijleraar,
                Tijd = 1130
            };

            Student student1 = new Student()
            {
                Naam = "Arthur",
                Lespakket = new LesPakket { UrenGekocht = 300, UrenVerbruikt = 700, ExamenPogingen = 2, Automaat = true },
                TheorieTest = new TheorieTest { AantalFouten = 3, AfnameDate = DateTime.Now.AddDays(-10), Gehaald = true },
                RijTest = new RijTest { Gehaald = true, AfnameDatum = DateTime.Now.AddDays(-10) }
            };

            Dag dag1 = new Dag();
            

            Student student2 = new Student()
            {
                Naam = "Arthur",
                Lespakket = new LesPakket { UrenGekocht = 500, UrenVerbruikt = 250, ExamenPogingen = 5, Automaat = false },
                TheorieTest = new TheorieTest { AantalFouten = 5, AfnameDate = DateTime.Now.AddDays(-2), Gehaald = true },
                RijTest = new RijTest { Gehaald = false, AfnameDatum = DateTime.Now.AddDays(-2) }
            };

            LesUur lesUur2 = new LesUur
            {
                Auto = auto2,
                Rijleraar = rijleraar
            };
            


            Console.WriteLine("Dag ingepland met lesuren:");
            foreach (var uur in dag1.LesUren)
            {
                Console.WriteLine($"Auto: {uur.Auto.Merk}, Leraar: {uur.Rijleraar.Naam}");
            }
        }
    }
}