using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double spring = 3000;
            const double summerAutumn = 4200;
            const double winter = 2600;
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            //Цената зависи от сезона:
            // Цената за наем на кораба през пролетта е 3000 лв.
            // Цената за наем на кораба през лятото и есента е 4200 лв.
            // Цената за наем на кораба през зимата е 2600 лв.
            //В зависимост от броя си групата ползва отстъпка:
            // Ако групата е до 6 човека включително – отстъпка от 10 %.
            // Ако групата е от 7 до 11 човека включително – отстъпка от 15 %.
            // Ако групата е от 12 нагоре – отстъпка от 25 %.
            //5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат
            //допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
            switch (season)
            {
                case "Spring":
                    if (numberOfFisherman <= 6)
                    {
                        finalPrice = spring - (0.1 * spring);
                    }
                    
                    else if (numberOfFisherman <= 11&&numberOfFisherman>=7)
                    {
                        finalPrice = spring - (0.15 * spring);
                    }
                    
                    else if (numberOfFisherman >= 12)
                    {
                        finalPrice = spring - (0.25 * spring);
                    }
                    
                    if (numberOfFisherman % 2 == 0)
                    {
                        finalPrice = finalPrice - (0.05 * finalPrice);
                    }
                    else
                    {
                        finalPrice = finalPrice;
                    }
                    break;
                case "Summer":
                    if (numberOfFisherman <= 6)
                    {
                        finalPrice = summerAutumn - (0.1 * summerAutumn);
                    }
                    
                    else if (numberOfFisherman <= 11 && numberOfFisherman >= 7)
                    {
                        finalPrice = summerAutumn - (0.15 * summerAutumn);
                    }
                    
                    else if (numberOfFisherman >= 12)
                    {
                        finalPrice = summerAutumn - (0.25 * summerAutumn);
                    }
                    
                    if (numberOfFisherman % 2 == 0)
                    {
                        finalPrice = finalPrice - (0.05 * finalPrice);
                    }
                    else
                    {
                        finalPrice = finalPrice;
                    }
                    break;
                case "Autumn":
                    if (numberOfFisherman <= 6)
                    {
                        finalPrice = summerAutumn - (0.1 * summerAutumn);
                    }
                    
                    else if (numberOfFisherman <= 11 && numberOfFisherman >= 7)
                    {
                        finalPrice = summerAutumn - (0.15 * summerAutumn);
                    }
                    
                    else if (numberOfFisherman >= 12)
                    {
                        finalPrice = summerAutumn - (0.25 * summerAutumn);
                    }
                    
                    
                    break;
                case "Winter":
                    if (numberOfFisherman <= 6)
                    {
                        finalPrice = winter - (0.1 * winter);
                    }
                    
                    else if (numberOfFisherman <= 11 && numberOfFisherman >= 7)
                    {
                        finalPrice = winter - (0.15 * winter);
                    }
                    
                    else if (numberOfFisherman >= 12)
                    {
                        finalPrice = winter - (0.25 * winter);
                    }
                    
                    if (numberOfFisherman % 2 == 0)
                    {
                        finalPrice = finalPrice - (0.05 * finalPrice);
                    }
                    else
                    {
                        finalPrice = finalPrice;
                    }
                    break;
            }
            double moneyLeft = Math.Abs(budget - finalPrice);
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
            }
// Ако бюджетът е достатъчен: Yes! You have { останалите пари} leva left.
// Ако бюджетът НЕ Е достатъчен: Not enough money! You need { сумата, която не достигa} leva.
        }
    }
}
