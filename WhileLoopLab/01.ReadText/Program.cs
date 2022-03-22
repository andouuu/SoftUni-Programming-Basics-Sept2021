using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            while (city != "Stop")
            {
                Console.WriteLine(city);
                city = Console.ReadLine();
            }
        }
    }
}
