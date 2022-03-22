using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double percentFull = double.Parse(Console.ReadLine());
            double obem = a * b * h;
            double liters = obem * 0.001;
            double lNeeded = liters*(1-percentFull / 100);
            Console.WriteLine(lNeeded);
        }
    }
}
