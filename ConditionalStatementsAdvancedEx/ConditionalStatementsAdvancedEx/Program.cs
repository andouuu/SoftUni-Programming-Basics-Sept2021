using System;

namespace ConditionalStatementsAdvancedEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int amountOfLines = int.Parse(Console.ReadLine());
            int amountOfCollumns = int.Parse(Console.ReadLine());
            double totalAmountOfSeats = amountOfCollumns * amountOfLines;
            double fullPrice = 0;
            switch (typeOfProjection)
            {
                case "Premiere":
                    fullPrice = totalAmountOfSeats * 12;
                    Console.WriteLine($"{fullPrice:f2} leva");
                    break;
                case "Normal":
                    fullPrice = totalAmountOfSeats * 7.5;
                    Console.WriteLine($"{fullPrice:f2} leva");
                    break;
                case "Discount":
                    fullPrice = totalAmountOfSeats * 5;
                    Console.WriteLine($"{fullPrice:f2} leva");
                    break;
            }
        }
    }
}
