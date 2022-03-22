using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaningSol = int.Parse(Console.ReadLine());
            int sale = int.Parse(Console.ReadLine());
            double Price = pens * 5.80 + markers * 7.20 + cleaningSol * 1.20;
            double fPrice = Price - (Price*sale/100);
            Console.WriteLine(fPrice);
        }
    }
}
