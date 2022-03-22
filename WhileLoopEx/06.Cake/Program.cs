using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int areaOfCake = width * lenght;
            string pieces = Console.ReadLine();
            while (pieces != "STOP")
            {
                int piecesEaten = int.Parse(pieces);
                areaOfCake -= piecesEaten;
                if (areaOfCake < 0)
                {
                    break;
                }
                pieces = Console.ReadLine();
            }
            if (areaOfCake >= 0)
            {
                Console.WriteLine($"{areaOfCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(areaOfCake)} pieces more.");
            }
        }
    }
}
