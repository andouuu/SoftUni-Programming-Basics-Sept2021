using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (a == "square")
            {
                double sideSQ = double.Parse(Console.ReadLine());
                double areaSQ = Math.Round(sideSQ * sideSQ, 3);
                Console.WriteLine("{0:F3}", areaSQ);
            }
            else if (a == "rectangle")
            {
                double sideRECT = double.Parse(Console.ReadLine());
                double sideRECT2 = double.Parse(Console.ReadLine());
                double areaRECT = Math.Round(sideRECT * sideRECT2, 3);
                Console.WriteLine("{0:F3}", areaRECT);
            }
            else if (a == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaC = Math.Round(radius * radius * Math.PI, 3);
                Console.WriteLine("{0:F3}", areaC);
            }
            else if (a == "triangle")
            {
                double sideTRI = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double areaTRI = Math.Round((sideTRI * height) / 2, 3);
                Console.WriteLine("{0:F3}", areaTRI);
            }
        }
    }
}
