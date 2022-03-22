using System;

namespace _03.ExcursionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
//             Пролет(spring)     Лято(summer)       Есен(autumn)       Зима(winter)
//До 5 човека  50.00 лв.на човек  48.50 лв.на човек  60.00 лв.на човек  86.00 лв.на човек
//Над 5 човека 48.00 лв.на човек  45.00 лв.на човек  49.50 лв.на човек  85.00 лв.на човек

            int numOfPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalPrice = 0;
            double discountedPrice = 0;
            switch (season)
            {
                case "spring":
                    if (numOfPeople<=5)
                    {
                        totalPrice = numOfPeople * 50.00;
                    }
                    else
                    {
                        totalPrice = numOfPeople * 48.00;
                    }
                    break;
                case "summer":
                    if (numOfPeople <= 5)
                    {
                        totalPrice = (numOfPeople * 48.50)*0.85;
                    }
                    else
                    {
                        totalPrice = (numOfPeople * 45.00)*0.85;
                    }
                    break;
                case "autumn":
                    if (numOfPeople <= 5)
                    {
                        totalPrice = numOfPeople * 60.00;
                    }
                    else
                    {
                        totalPrice = numOfPeople * 49.50;
                    }
                    break;
                case "winter":
                    if (numOfPeople <= 5)
                    {
                        totalPrice = (numOfPeople * 86.00)*1.08;
                    }
                    else
                    {
                        totalPrice = (numOfPeople * 85.00)*1.08;
                    }
                    break;
            }
            Console.WriteLine($"{totalPrice:f2} leva.");
        }
    }
}
