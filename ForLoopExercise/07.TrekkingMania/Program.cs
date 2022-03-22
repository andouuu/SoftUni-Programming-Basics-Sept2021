using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double musalaNums = 0;
            double monblanNums = 0;
            double kilimanNums = 0;
            double k2Nums = 0;
            double everestNums = 0;
            double sumPeople = 0;
            for (int i = 0; i < n; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());
                sumPeople += numOfPeople;
                if (numOfPeople < 6)
                {
                    musalaNums += numOfPeople;
                }
                else if (numOfPeople >= 6 && numOfPeople <= 12)
                {
                    monblanNums += numOfPeople;
                }
                else if (numOfPeople > 12 && numOfPeople <= 25)
                {
                    kilimanNums += numOfPeople;
                }
                else if (numOfPeople > 25 && numOfPeople <= 40)
                {
                    k2Nums += numOfPeople;
                }
                else
                {
                    everestNums += numOfPeople;
                }
            }
            Console.WriteLine($"{musalaNums/sumPeople*100:f2}%");
            Console.WriteLine($"{monblanNums/sumPeople*100:f2}%");
            Console.WriteLine($"{kilimanNums/sumPeople*100:f2}%");
            Console.WriteLine($"{k2Nums/sumPeople*100:f2}%");
            Console.WriteLine($"{everestNums/sumPeople*100:f2}%");
        }
    }
}
