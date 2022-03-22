using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 2000;
            int f = 1200;
            int sf = 720;
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int finalPoints = startingPoints;
            double tournamentsWon = 0;
            for (int i = 0; i < n; i++)
            {
                string rank = Console.ReadLine();
                if (rank=="W")
                {
                    finalPoints += w;
                    tournamentsWon += 1;
                }
                else if (rank == "F")
                {
                    finalPoints += f;
                }
                else if (rank == "SF")
                {
                    finalPoints += sf;
                }
            }
            double averagePoints = Math.Floor((finalPoints - startingPoints)*1.00 / n);
            double percentTournamentsWont = tournamentsWon / n * 100;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentTournamentsWont:f2}%");
        }
    }
}
