using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;
            while (money != "NoMoreMoney")
            {
                double amount = double.Parse(money);
                if (amount >= 0)
                {
                    Console.WriteLine($"Increase: {amount:f2}");
                    sum += amount;
                    money = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
