using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthAp = int.Parse(Console.ReadLine());
            int lengthAp = int.Parse(Console.ReadLine());
            int heigthAp = int.Parse(Console.ReadLine());
            int quM = widthAp * lengthAp * heigthAp;
            string box = Console.ReadLine();
            while (box != "Done")
            {
                int boxes = int.Parse(box);
                quM -= boxes;
                if (quM < 0)
                {
                    break;
                }
                box = Console.ReadLine();
            }
            if (quM >= 0)
            {
                Console.WriteLine($"{quM} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(quM)} Cubic meters more.");
            }
        }
    }
}
