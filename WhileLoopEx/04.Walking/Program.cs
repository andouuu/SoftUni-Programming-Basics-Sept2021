using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int sum = 0;
            bool goingHome = false;
            while (sum < 10000)
            {
                
                
                
                
                if (steps=="Going home")
                {
                    goingHome = true;
                    int homeSteps = int.Parse(Console.ReadLine());
                    sum += homeSteps;
                    break;
                }
                int numSteps = int.Parse(steps);
                sum += numSteps;
                steps = Console.ReadLine();
            }
            if (sum<10000)
            {
                Console.WriteLine($"{10000-sum} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{sum-10000} steps over the goal!");
            }
        }
    }
}
