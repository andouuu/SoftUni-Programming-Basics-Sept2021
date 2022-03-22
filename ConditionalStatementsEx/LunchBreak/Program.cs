using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvSeries = Console.ReadLine();
            int epizode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double lunch = breakTime*1.00 / 8;
            double chill = breakTime*1.00 / 4;
            double timeLeft = breakTime - (lunch + chill);
            double freeTime =Math.Abs(timeLeft - epizode);
            if (timeLeft>=epizode)
            {
                Console.WriteLine($"You have enough time to watch {tvSeries} and left with {Math.Ceiling(freeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {tvSeries}, you need {Math.Ceiling(freeTime)} more minutes.");
            }
        }
    }
}
