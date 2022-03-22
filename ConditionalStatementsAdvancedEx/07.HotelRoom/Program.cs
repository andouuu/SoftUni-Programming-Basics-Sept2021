using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            const double apMayOct = 65;
            const double stMayOct = 50;
            const double apJuneSep = 68.70;
            const double stJuneSep = 75.20;
            const double apJulyAug = 77;
            const double stJulyAug = 76;
            string month = Console.ReadLine();
            int amountDays = int.Parse(Console.ReadLine());
            double priceAp = 0;
            double priceSt = 0;
            // За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            // За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            // За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            // За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            switch (month)
            {
                case "May":
                case "October":
                    if (amountDays > 7 && amountDays <= 14)
                    {
                        priceSt = (amountDays * stMayOct) - (0.05 * (amountDays * stMayOct));
                        priceAp = amountDays * apMayOct;
                    }
                    else if (amountDays > 14)
                    {
                        priceSt = (amountDays * stMayOct) - (0.3 * (amountDays * stMayOct));
                        priceAp = (amountDays * apMayOct)-(0.1*(amountDays*apMayOct));
                    }
                    else
                    {
                        priceSt = amountDays * stMayOct;
                        priceAp = amountDays * apMayOct;
                    }
                    break;
                    case "June":
                case "September":
                    if (amountDays > 14)
                    {
                        priceSt = (amountDays * stJuneSep) - (0.2 * (amountDays * stJuneSep));
                        priceAp = (amountDays * apJuneSep) - (0.1 * (amountDays * apJuneSep));
                    }
                    else
                    {
                        priceSt = amountDays * stJuneSep;
                        priceAp = amountDays * apJuneSep;
                    }
                    break;
                    case "July":
                case "August":
                    if (amountDays > 14)
                    {
                        priceSt = amountDays * stJulyAug;
                        priceAp = (amountDays * apJulyAug) - (0.1 * (amountDays * apJulyAug));
                    }
                    else
                    {
                        priceSt = amountDays * stJulyAug;
                        priceAp = amountDays * apJulyAug;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {priceAp:f2} lv.");
            Console.WriteLine($"Studio: {priceSt:f2} lv.");
        }
    }
}
