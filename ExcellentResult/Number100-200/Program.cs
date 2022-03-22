using System;

namespace Number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a<100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100<=a&&a<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (200<a)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
