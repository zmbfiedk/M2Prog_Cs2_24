namespace Dictionaries
{
    internal class Program
    {
     Dictionary<string, Room> rooms = new Dictionary<string, Room>();
           

       
        
        static void Main(string[] args)
        {
          Program p = new Program();
            p.Run();
        }
        
        Dictionary<int, string> personeelopNr = new Dictionary<int, string>();
        internal void Run()
        {
             rooms.Add(Start.GetRoomLocationKey(), start);
         

            personeelopNr.Add(12345,"Tim");
            personeelopNr.Add(54321, "Jay");
            personeelopNr.Add(657893327, "arthur");

            string T = personeelopNr[12345];
            string J = personeelopNr[54321];
            string A = personeelopNr[657893327];

            Console.WriteLine(T);
            Console.WriteLine(J);
            Console.WriteLine(A);

            foreach (KeyValuePair<int, string> item in personeelopNr)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key);
            }

            foreach (int key in personeelopNr.Keys)
            {
             Console.WriteLine(key);
            }

            foreach (string value in personeelopNr.Values)
            {
            Console.WriteLine(value);
            }

        }
    }
}
