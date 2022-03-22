using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle= 2.60;
            double doll= 3;
            double bear= 4.10;
            double minion= 8.20;
            double truck= 2;
            double exPrice = double.Parse(Console.ReadLine());
            int puzzleC = int.Parse(Console.ReadLine());
            int dollC = int.Parse(Console.ReadLine());
            int bearC = int.Parse(Console.ReadLine());
            int minionC = int.Parse(Console.ReadLine());
            int truckC = int.Parse(Console.ReadLine());
            int amountToys = puzzleC + dollC + bearC + minionC + truckC;
            double totalP = puzzle * puzzleC + doll * dollC + bear * bearC + minion * minionC + truck * truckC;
            if (amountToys>=50)
            {
                totalP *= 0.75;
            }
            double naem = 0.1 * totalP;
            double winings = totalP - naem;
            double moneyleft = Math.Abs(winings - exPrice);
            if (winings>=exPrice)
            {
                Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyleft:f2} lv needed.");
            }
        }
    }
}
