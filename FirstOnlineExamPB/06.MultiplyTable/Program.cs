using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diggit1 = n / 100;
            int diggit2 = n / 10 % 10;
            int diggit3 = n % 10;
            for (int i = 1; i <= diggit3; i++)
            {
                for (int j = 1; j <= diggit2; j++)
                {
                    for (int k = 1; k <= diggit1; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i*j*k}; ");
                    }
                }
            }
        }
    }
}
