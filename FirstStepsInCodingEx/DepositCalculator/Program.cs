using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositamount = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double yearly = double.Parse(Console.ReadLine());
            double amount = depositamount + period * ((depositamount * yearly/100) / 12);
            Console.WriteLine(amount);
        }
    }
}
