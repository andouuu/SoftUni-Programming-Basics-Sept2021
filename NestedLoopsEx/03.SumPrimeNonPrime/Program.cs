using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input!="stop")
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if ((num%2==0&&num!=2)||(num%3==0&&num!=3)||(num%5==0&&num!=5)||(num%7==0&&num!=7)&&num!=0)
                {
                    nonPrimeSum += num;
                }
                else
                {
                    primeSum += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
