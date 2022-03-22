using System;

namespace _03.NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roses = 5;
            const double dahlias = 3.8;
            const double tulips = 2.8;
            const double narcissus = 3;
            const double gladiolus = 2.5;
            string flowerType = Console.ReadLine();
            int amountOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            // Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            // Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            // Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            // Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            // Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            switch (flowerType)
            {
                case "Roses":
                    if (amountOfFlowers > 80)
                    {
                        finalPrice = (roses * amountOfFlowers) - (0.1 * (roses * amountOfFlowers));
                    }
                    else
                    {
                        finalPrice = roses * amountOfFlowers;
                    }
                    break;
                case "Dahlias":
                    if (amountOfFlowers > 90)
                    {
                        finalPrice = (dahlias * amountOfFlowers) - (0.15 * (dahlias * amountOfFlowers));
                    }
                    else
                    {
                        finalPrice = dahlias * amountOfFlowers;
                    }
                    break;
                case "Tulips":
                    if (amountOfFlowers > 80)
                    {
                        finalPrice = (tulips * amountOfFlowers) - (0.15 * (tulips * amountOfFlowers));
                    }
                    else
                    {
                        finalPrice = tulips * amountOfFlowers;
                    }
                    break;
                case "Narcissus":
                    if (amountOfFlowers < 120)
                    {
                        finalPrice = (narcissus * amountOfFlowers) + (0.15 * (narcissus * amountOfFlowers));
                    }
                    else
                    {
                        finalPrice = narcissus * amountOfFlowers;
                    }
                    break;
                case "Gladiolus":
                    if (amountOfFlowers < 80)
                    {
                        finalPrice = (gladiolus * amountOfFlowers) + (0.2 * (gladiolus * amountOfFlowers));
                    }
                    else
                    {
                        finalPrice = gladiolus * amountOfFlowers;
                    }
                    break;
                

            }
            double moneyLeft = Math.Abs(budget - finalPrice);
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountOfFlowers} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyLeft:f2} leva more.");
            }
            // Ако бюджета им е достатъчен - Hey, you have a great garden with {броя цвета}
            //{видцветя} and { останалата сума} leva left.
            // Ако бюджета им е НЕ достатъчен - Not enough money, you need { нужната сума} leva more.
        }
    }
}
