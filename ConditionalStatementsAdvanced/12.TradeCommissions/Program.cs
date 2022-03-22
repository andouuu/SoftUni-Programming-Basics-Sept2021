using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Град    0 ≤ s ≤ 500   500 < s ≤ 1 000   1 000 < s ≤ 10 000   s > 10 000
            //Sofia   5 %           7 %               8 %                  12 %
            //Varna   4.5 %         7.5 %             10 %                 13 %
            //Plovdiv 5.5 %         8 %               12 %                 14.5 %
            string city = Console.ReadLine();
            double volumeOfSales = double.Parse(Console.ReadLine());
            double commission = 0;
            switch (city)
            {
                case "Sofia":
                    if (volumeOfSales >= 0 && volumeOfSales <= 500)
                    {
                        commission = volumeOfSales * 0.05;
                        Console.WriteLine("{0:F2}",commission);
                    }
                    else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                    {
                        commission = volumeOfSales * 0.07;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales >1000 && volumeOfSales <= 10000)
                    {
                        commission = volumeOfSales * 0.08;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales >10000)
                    {
                        commission = volumeOfSales * 0.12;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (volumeOfSales >= 0 && volumeOfSales <= 500)
                    {
                        commission = volumeOfSales * 0.045;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                    {
                        commission = volumeOfSales * 0.075;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
                    {
                        commission = volumeOfSales * 0.10;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales > 10000)
                    {
                        commission = volumeOfSales * 0.13;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (volumeOfSales >= 0 && volumeOfSales <= 500)
                    {
                        commission = volumeOfSales * 0.055;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                    {
                        commission = volumeOfSales * 0.08;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
                    {
                        commission = volumeOfSales * 0.12;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (volumeOfSales > 10000)
                    {
                        commission = volumeOfSales * 0.145;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
