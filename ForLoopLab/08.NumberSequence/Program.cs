using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersQuantity = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < numbersQuantity; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
