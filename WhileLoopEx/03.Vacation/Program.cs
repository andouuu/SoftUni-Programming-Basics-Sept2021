using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());
            
            int days = 0;
            int timesSpend = 0;
            while (moneyHave < moneyNeeded&&timesSpend<5 )
            {
                string type = Console.ReadLine();
            double moneySpendSaved = double.Parse(Console.ReadLine());
                days++;
                switch (type)
                {
                    case "spend":
                        moneyHave -= moneySpendSaved;
                        timesSpend++;
                        if (moneyHave < 0)
                        {
                            moneyHave = 0;
                        }
                        break;
                    case "save":
                        moneyHave += moneySpendSaved;
                        timesSpend = 0;
                        break;
                }
                
            }
            if (timesSpend == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }
           if(moneyHave>=moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
