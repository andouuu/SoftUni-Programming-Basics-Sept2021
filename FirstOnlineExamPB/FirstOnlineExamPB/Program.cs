using System;

namespace FirstOnlineExamPB
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dollarInBgn = 1.57;
            double processorPriceInDollars = double.Parse(Console.ReadLine());
            double videoCardPriceInDollars = double.Parse(Console.ReadLine());
            double ramPriceInDollars = double.Parse(Console.ReadLine());
            int amountRam = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double processorPriceInLv = processorPriceInDollars * 1.57;
            double videoCardPriceInLv = videoCardPriceInDollars * 1.57;
            double ramPriceInLv = ramPriceInDollars * 1.57;

            double fullRamPrice = ramPriceInLv * amountRam;
            double finalProcessorPrice = processorPriceInLv - (processorPriceInLv * percentDiscount);
            double finalVideoCardPrice = videoCardPriceInLv - (videoCardPriceInLv * percentDiscount);

            double total = fullRamPrice + finalProcessorPrice + finalVideoCardPrice;
            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
