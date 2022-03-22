using System;

namespace WorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double metersPS = double.Parse(Console.ReadLine());
            double ivanTime = meters * metersPS;
            double addedTime = Math.Floor(meters / 15) * 12.5;
            double finalTime = addedTime + ivanTime;
            double timeLeft = Math.Abs(finalTime - record);
            if (finalTime<record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeLeft:f2} seconds slower.");
            }
        }
    }
}
