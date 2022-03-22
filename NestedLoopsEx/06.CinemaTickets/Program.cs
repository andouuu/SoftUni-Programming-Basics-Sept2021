using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTickets = 0;
            string movieName = Console.ReadLine();
            
            while (movieName!="Finish")
            {
                int student = 0;
                int standard = 0;
                int kid = 0;
                int freeSeats = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSeats; i++)               
                {
                    string type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    switch (type)
                    {

                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                    
                }
                studentTickets += student;
                standardTickets += standard;
                kidTickets += kid;
                double percentFull = ((student + standard + kid) / (double)freeSeats)*100;
                Console.WriteLine($"{movieName} - {percentFull:f2}% full.");

                movieName = Console.ReadLine();
            }
            totalTickets = kidTickets + standardTickets + studentTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            double standardPercent = standardTickets / (double)totalTickets * 100;
double studentPercent = studentTickets / (double)totalTickets * 100;
double kidPercent = kidTickets / (double)totalTickets * 100;
            Console.WriteLine($"{studentPercent:f2}% student tickets.");            
            Console.WriteLine($"{standardPercent:f2}% standard tickets.");            
            Console.WriteLine($"{kidPercent:f2}% kids tickets.");
        }
    }
}
