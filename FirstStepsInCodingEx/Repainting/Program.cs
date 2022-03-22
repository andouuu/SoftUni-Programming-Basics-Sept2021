using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double nylonP = (nylon + 2) * 1.50;
            double paintP = (paint * 1.1)*14.5;
            double thinnerP = thinner * 5;
            double materialP = nylonP + paintP + thinnerP + 0.4;
            double workersP = (materialP * 0.3) * hours;
            double finalP = materialP + workersP;
            Console.WriteLine(finalP);
        }
    }
}
