using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double sum = 0;
            string lastProblem = "";
            bool isfailed = true;
            while (failedTimes<failedThreshold)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isfailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes ++;
                }
                sum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if (isfailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Äverage score: {sum/solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
