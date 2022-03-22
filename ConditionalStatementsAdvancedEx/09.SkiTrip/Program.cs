using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roomForOne = 18.00;
            const double apartment = 25.00;
            const double presidentApart = 35.00;
            int daysStaying = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            int nightsStaying = daysStaying - 1;
            double finalPrice = 0;
            double discountedPrice = 0;
            switch(roomType)
            {
                case "room for one person":
                    if (rating == "positive")
                    {
                        finalPrice = (roomForOne * nightsStaying) + (0.25 * (roomForOne * nightsStaying));
                    }
                    else if (rating == "negative")
                    {
                        finalPrice = (roomForOne * nightsStaying) - (0.1 * (roomForOne * nightsStaying));
                    }
                    break;
                case "apartment":
                    if (nightsStaying < 10)
                    {
                        discountedPrice = (apartment * nightsStaying) - (0.3 * (apartment * nightsStaying));
                        if (rating == "positive")
                        {
                            finalPrice = discountedPrice + (0.25 * discountedPrice);
                        }
                        else if (rating == "negative")
                        {
                            finalPrice = discountedPrice - (0.1 * discountedPrice);
                        }
                    }
                    if (nightsStaying >= 10&&nightsStaying<=15)
                    {
                        discountedPrice = (apartment * nightsStaying) - (0.35 * (apartment * nightsStaying));
                        if (rating == "positive")
                        {
                            finalPrice = discountedPrice + (0.25 * discountedPrice);
                        }
                        else if (rating == "negative")
                        {
                            finalPrice = discountedPrice - (0.1 * discountedPrice);
                        }
                    }
                    if (nightsStaying > 15)
                    {
                        discountedPrice = (apartment * nightsStaying) - (0.5 * (apartment * nightsStaying));
                        if (rating == "positive")
                        {
                            finalPrice = discountedPrice + (0.25 * discountedPrice);
                        }
                        else if (rating == "negative")
                        {
                            finalPrice = discountedPrice - (0.1 * discountedPrice);
                        }
                    }
                    break;
                case "president apartment":
                    if (nightsStaying < 10)
                    {
                        discountedPrice = (presidentApart * nightsStaying) - (0.1 * (presidentApart * nightsStaying));
                        if (rating == "positive")
                        {
                            finalPrice = discountedPrice + (0.25 * discountedPrice);
                        }
                        else if (rating == "negative")
                        {
                            finalPrice = discountedPrice - (0.1 * discountedPrice);
                        }
                    }
                    if (nightsStaying >= 10 && nightsStaying <= 15)
                    {
                        discountedPrice = (presidentApart * nightsStaying) - (0.15 * (presidentApart * nightsStaying));
                        if (rating == "positive")
                        {
                            finalPrice = (discountedPrice) + (0.25 * discountedPrice);
                        }
                        else if (rating == "negative")
                        {
                            finalPrice = discountedPrice - (0.1 * discountedPrice);
                        }
                    }
                    if (nightsStaying > 15)
                    {
                        discountedPrice = (presidentApart * nightsStaying) - (0.20 * (presidentApart * nightsStaying));
                        if (rating == "positive")
                        {
                            finalPrice = discountedPrice + (0.25 * discountedPrice);
                        }
                        else if (rating == "negative")
                        {
                            finalPrice = discountedPrice - (0.1 * discountedPrice);
                        }
                    }
                    break;
            }
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
