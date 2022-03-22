using System;

namespace _04.GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalLitters = 0;
            double degrees = 0;
            for (int i = 0; i < n; i++)
            {
                double littersDay = double.Parse(Console.ReadLine());
                double degreesDay = double.Parse(Console.ReadLine());
                totalLitters += littersDay;
                degrees =degrees+ degreesDay * littersDay;
            }
            double averageDegrees = degrees / totalLitters;
            Console.WriteLine($"Liter: {totalLitters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegrees >= 38 && averageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
