using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        FileManager fileManager = new FileManager();
        string menu;
        string filename = "tickets.txt";
        do
        {

            Console.WriteLine("1. Write data to file");
            Console.WriteLine("2. Read data from file");
            Console.WriteLine("3. Exit");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                fileManager.Read(filename);

            }
            else if (menu == "2")
            {
                if (File.Exists("tickets.txt"))
                {
                    fileManager.Write(filename);



                }

            }
        }
        while (menu != "3");



    }


    public class FileManager
    {
        public void Read(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            
            
            // asking user
            Console.WriteLine("Enter a ticket ID number\n");
            var ticketID = Console.ReadLine();
            sw.WriteLine(ticketID);
            Console.Write("Enter a summary for this ticket id\n");
            var summary = Console.ReadLine();
            Console.Write("Enter a status for this ticket id\n");
            var status = Console.ReadLine();
            Console.Write("Enter a priority for this ticket id\n");
            var priority = Console.ReadLine();
            Console.Write("Enter a submitter for this ticket id\n");
            var submitter = Console.ReadLine();
            Console.Write("Enter a assigned person for this ticket id\n");
            var assigned = Console.ReadLine();

            sw.WriteLine("TicketID, Summary, Status, Priority, Submitter, Assigned, Watching");
            

            string[] watchers = new string[5];
            
            Console.WriteLine("How many people are watching");
            int numberOfWatchers = Int32.Parse(Console.ReadLine());

            string input = null;
            for(int i = 0; i < numberOfWatchers; i++)
            {
                Console.WriteLine($"Enter the name of the people? ");
                input = Console.ReadLine();

                watchers[i] = input;
                
            }
            
           
            
            
            

            sw.WriteLine($"{ticketID}, {summary}, {status}, {priority}, {submitter}, {assigned}, {input}");

            sw.Close();

        }
        public void Write(string filename)
        {
            StreamReader sr = new StreamReader(filename);

            if (sr.EndOfStream != true)
            {
                var line = sr.ReadToEnd();
                Console.WriteLine(line);


            }
        }
    }
}

   

