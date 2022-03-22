using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double convertedChange = money * 100;
            int cents = (int)convertedChange;
            int sum = 0;

            while (cents >0)
            {
                if (cents - 200>=0)
                {
                    cents -= 200;
                    sum += 1;
                    
                }
                else if (cents -100>=0)
                {
                    cents -= 100;
                    sum += 1;
                }
                else if (cents -50>=0)
                {
                    cents -= 50;
                    sum += 1;
                }
                else if (cents -20>=0)
                {
                    cents -= 20;
                    sum += 1;
                }
                else if (cents -10>=0)
                {
                    cents -= 10;
                    sum += 1;
                }
                else if (cents -5>=0)
                {
                    cents -= 5;
                    sum += 1;
                }
                else if (cents -2>=0)
                {
                    cents -= 2;
                    sum += 1;
                }
                else if (cents -1>=0)
                {
                    cents -= 1;
                    sum += 1;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
