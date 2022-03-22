using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());
            double moneyReceived = 0;
            int moneyTakenFromBrother = 0;
            int numberOfToys = 0;
            for (int i = 1; i <=n ; i++)
            {
                if (i % 2 == 0)
                {
                    moneyReceived = moneyReceived + (1.0 * 10 * i / 2);
                    moneyTakenFromBrother += 1;
                }
                else
                {
                    numberOfToys += 1;
                }
            }
            double moneySheHas = (numberOfToys * pricePerToy) + (moneyReceived - moneyTakenFromBrother);
            double moneyNeeded = Math.Abs(moneySheHas - priceWashingMachine);
            if (moneySheHas >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {moneyNeeded:f2}");
            }
            else
            {
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
