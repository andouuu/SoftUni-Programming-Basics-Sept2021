using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string archi = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());

            int hours = br * 3;
            Console.WriteLine($"The architect {archi} will need {hours} hours to complete {br} project/s.");

        }
    }
}
