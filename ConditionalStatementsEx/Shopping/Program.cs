using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int vcP = 250;
            double budget = double.Parse(Console.ReadLine());
            int amountVC = int.Parse(Console.ReadLine());
            int amountPr = int.Parse(Console.ReadLine());
            int amountRam = int.Parse(Console.ReadLine());
            double videoCPrice = amountVC * vcP;
            double procPrice = (videoCPrice * 0.35) * amountPr;
            double ramPrice = (videoCPrice * 0.1) * amountRam;
            double finalPrice = videoCPrice + procPrice + ramPrice;
            if (amountVC>amountPr)
            {
                finalPrice *= 0.85;
            }
            double moneyLeft = Math.Abs(budget - finalPrice);
            if (budget>=finalPrice)
            {
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva more!");
            }
        }
    }
}
