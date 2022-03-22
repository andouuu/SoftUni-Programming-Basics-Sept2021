using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1 ;
            int livesRemaining = 2;
            double sumOfGrades = 0;
            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    year += 1;
                    sumOfGrades += grade;
                }
                else
                {
                    livesRemaining -= 1;

                }
                if (livesRemaining==0)
                {
                    break;
                }
                
                
            }
            if (livesRemaining == 0)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");

            }
            else
            {
                double averageGrade = sumOfGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
