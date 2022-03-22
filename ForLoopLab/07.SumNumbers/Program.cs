using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersQuantity = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbersQuantity; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
