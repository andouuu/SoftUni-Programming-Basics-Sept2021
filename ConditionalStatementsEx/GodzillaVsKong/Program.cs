using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stuntNum = int.Parse(Console.ReadLine());
            double stuntClothesNum = double.Parse(Console.ReadLine());
            double stuntClPrice = stuntNum * stuntClothesNum;
            double decor = budget * 0.1;
            if (stuntNum>150)
            {
                stuntClPrice *= 0.9;
            }
            double fullPrice = decor + stuntClPrice;
            double moneyleft = Math.Abs(budget - fullPrice);
            if (budget<fullPrice)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {moneyleft:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {moneyleft:f2} leva left.");
            }
        }
    }
}
