using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            int amountOfPresentations = 0;
            int amountOfGrades = 0;
            double sumOfGrades = 0;
            double sumOfGradesAllPresentations = 0;
            while (nameOfPresentation != "Finish")
            {
                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    amountOfGrades++;
                    
                }
                double averageGrade = sumOfGrades / amountOfGrades;
                Console.WriteLine($"{nameOfPresentation} - {averageGrade:f2}.");
                sumOfGradesAllPresentations += averageGrade;
                amountOfPresentations++;
                sumOfGrades = 0;
                amountOfGrades = 0;
                nameOfPresentation = Console.ReadLine();
            }
            double finalGrade = sumOfGradesAllPresentations / amountOfPresentations;
            Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");
        }
    }
}
