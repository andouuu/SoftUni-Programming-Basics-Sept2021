using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string juryName = Console.ReadLine();
                double pointsFromJury = double.Parse(Console.ReadLine());
                pointsFromAcademy += ((juryName.Length * pointsFromJury) / 2);
                if (pointsFromAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:f1}!");
                    break;
                }
            }
            double pointsNeeded = 1250.5 - pointsFromAcademy;
            if (pointsFromAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }
        }
    }
}
