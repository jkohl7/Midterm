using System;
using System.IO;
using System.Collections;


namespace TIcketObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do{
            //ask user what the want to create
            Console.WriteLine("Select type which ticket form you want to create.");
            Console.WriteLine("1.)Ticket -- 2.)Enhancement -- 3.)Task");
            Console.WriteLine("Press enter to quit");
            choice = Console.ReadLine();
        
        
        if(choice == "1")
        {
            //create array and read file
            ArrayList TDArray = new ArrayList();
            string file = "tickets.csv";
            StreamReader sr = new StreamReader(file);
           
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(",");
                TDArray.Add(arr);
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);

            //Promt the user 
            Console.WriteLine("Enter TicketID");
            string id = Console.ReadLine();
            Console.WriteLine("Enter a summary of the ticket");
            string summ = Console.ReadLine();
            Console.WriteLine("Enter the status of the ticket");
            string status = Console.ReadLine();
            Console.WriteLine("Enter the priority of the ticket");
            string prio = Console.ReadLine();
            Console.WriteLine("Enter the submiter of the ticket");
            string submit = Console.ReadLine();
            Console.WriteLine("Enter the assigner of the ticket");
            string assn = Console.ReadLine();
            Console.WriteLine("Enter the severity of the ticket");
            string sev = Console.ReadLine();


            //Asks and gets data for multiple users
            Console.WriteLine("Is anyone watching the ticket? (Y/N)");
            string reply = Console.ReadLine().ToUpper();

            bool whosWatching = true;
            if (reply.Equals("N")) whosWatching = false;
            string watch = "";
            while (whosWatching)
            {
                Console.WriteLine("Who is watching?");
                watch += Console.ReadLine();
                watch += "|";
                Console.WriteLine("Is there anyone else? (Y/N)");
                reply = Console.ReadLine().ToUpper();
                if (reply.Equals("N")) whosWatching = false;
            }
            String[] userInput = new string[] { id, summ, status, prio, submit, assn,  sev, watch};
              TDArray.Add(userInput);

            //Create an instance of the ticket object
            
              //Ticket made = new Ticket(id, summ,status, prio, submit, assn, watch);

            foreach (string[] l in TDArray)
            {
                for (int x = 0; x < 8; x++)
                {
                    sw.Write(l[x] + ",");

                }
                sw.WriteLine();

            }
            sw.Close();
        }else if (choice == "2")
        {
           ArrayList TDArray = new ArrayList();
            string file = "Enhancements.csv";
            StreamReader sr = new StreamReader(file);
           
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(",");
                TDArray.Add(arr);
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);

            //Promt the user 
            Console.WriteLine("Enter TicketID");
            string id = Console.ReadLine();
            Console.WriteLine("Enter a summary of the ticket");
            string summ = Console.ReadLine();
            Console.WriteLine("Enter the status of the ticket");
            string status = Console.ReadLine();
            Console.WriteLine("Enter the priority of the ticket");
            string prio = Console.ReadLine();
            Console.WriteLine("Enter the submiter of the ticket");
            string submit = Console.ReadLine();
            Console.WriteLine("Enter the assigner of the ticket");
            string assn = Console.ReadLine();
            Console.WriteLine("Enter the software for the ticket");
            string soft = Console.ReadLine();
            Console.WriteLine("Enter the Cost for the ticket");
            string cost = Console.ReadLine();
            Console.WriteLine("Enter the Reason for the ticket");
            string reason = Console.ReadLine();
            Console.WriteLine("Enter the Estimate of the ticket");
            string est = Console.ReadLine();


            //Asks and gets data for multiple users
            Console.WriteLine("Is anyone watching the ticket? (Y/N)");
            string reply = Console.ReadLine().ToUpper();

            bool whosWatching = true;
            if (reply.Equals("N")) whosWatching = false;
            string watch = "";
            while (whosWatching)
            {
                Console.WriteLine("Who is watching?");
                watch += Console.ReadLine();
                watch += "|";
                Console.WriteLine("Is there anyone else? (Y/N)");
                reply = Console.ReadLine().ToUpper();
                if (reply.Equals("N")) whosWatching = false;
            }
            String[] userInput = new string[] { id, summ, status, prio, submit, assn, soft, reason, est, watch};
              TDArray.Add(userInput);


           foreach (string[] l in TDArray)
            {
                for (int x = 0; x < 10; x++)
                {
                    sw.Write(l[x] + ",");

                }
                sw.WriteLine();

            }
            sw.Close();

        }else if (choice == "3")
        {
            Console.WriteLine("This is 3");
        }

         } while (choice == "1" || choice == "2" || choice =="3");


        }
    }
}

