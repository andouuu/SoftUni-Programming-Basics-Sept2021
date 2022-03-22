using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfStay="";
            string destination="";
            double priceOfStay = 0;
            
            // При 100лв.или по-малко – някъде в България
            //o Лято – 30 % от бюджета
            //o Зима – 70 % от бюджета
            // При 1000лв.или по малко – някъде на Балканите
            //o Лято – 40 % от бюджета
            //o Зима – 80 % от бюджета
            // При повече от 1000лв. – някъде из Европа
            //o При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        typeOfStay = "Camp";
                        priceOfStay = budget * 0.3;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        typeOfStay = "Camp";
                        priceOfStay = budget * 0.4;
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        typeOfStay = "Hotel";
                        priceOfStay = budget * 0.9;
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        typeOfStay = "Hotel";
                        priceOfStay = budget * 0.7;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        typeOfStay = "Hotel";
                        priceOfStay = budget * 0.8;
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        typeOfStay = "Hotel";
                        priceOfStay = budget * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfStay} - {priceOfStay:f2}");
        }
    }
}
