using System;

namespace _02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
           
            const double loveCard = 0.60;
            const double waxRose = 7.20;
            const double keyHolder = 3.60;
            const double caricature = 18.20;
            const double luckySurprise = 22.00;
            //Ако поръчаните артикули са 25 или повече магазинът прави отстъпка 35 % от общата цена.
            //    От спечелените пари Михаела трябва да предвиди и 10 % разход за хостинг
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int amountLoveCards = int.Parse(Console.ReadLine());
            int amountWaxRoses = int.Parse(Console.ReadLine());
            int amountKeyHolders = int.Parse(Console.ReadLine());
            int amountCaricatures = int.Parse(Console.ReadLine());
            int amountLuckySurprises = int.Parse(Console.ReadLine());

            double totalPrice = amountLoveCards * loveCard + amountWaxRoses * waxRose +
                amountKeyHolders * keyHolder + amountCaricatures * caricature
                + amountLuckySurprises * luckySurprise;
            int totalAmount = amountLoveCards + amountWaxRoses + amountKeyHolders
                + amountCaricatures + amountLuckySurprises;
            if (totalAmount >= 25)
            {
                totalPrice *= 0.65;
            }
            double hostingCost = totalPrice * 0.1;
            double finalPrice = totalPrice - hostingCost;
            
            if (finalPrice >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {finalPrice-maidenPartyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {maidenPartyPrice-finalPrice:f2} lv needed.");
            }
        }
    }
}
