using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            плод banana apple orange grapefruit kiwi pineapple grapes
            //цена             2.50   1.20  0.85   1.45       2.70 5.50     3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //            плод banana apple orange grapefruit kiwi pineapple grapes
            //цена             2.70   1.25  0.90   1.60       3.00 5.60      4.20
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double fullPrice = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            fullPrice=2.50*quantity ;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "apple":
                            fullPrice = 1.20 *quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "orange":
                            fullPrice = 0.85 *quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "grapefruit":
                            fullPrice = 1.45 *quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "kiwi":
                            fullPrice = 2.70 *quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "pineapple":
                            fullPrice = 5.50 *quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "grapes":
                            fullPrice = 3.85 *quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit) {
                        case "banana":
                            fullPrice = 2.70 * quantity;
                            Console.WriteLine("{0:F2}",fullPrice);
                            break;
                        case "apple":
                            fullPrice = 1.25 * quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "orange":
                            fullPrice = 0.90 * quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "grapefruit":
                            fullPrice = 1.60 * quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "kiwi":
                            fullPrice = 3.00 * quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "pineapple":
                            fullPrice = 5.60 * quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        case "grapes":
                            fullPrice = 4.20 * quantity;
                            Console.WriteLine("{0:F2}", fullPrice);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
                    
            }
        }
    }
}
