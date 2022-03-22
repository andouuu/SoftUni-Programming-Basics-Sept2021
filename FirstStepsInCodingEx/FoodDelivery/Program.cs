using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggie = int.Parse(Console.ReadLine());
            double menuP = chicken * 10.35 + fish * 12.4 + veggie * 8.15;
            double dessert = menuP * 0.2;
            double finalP = menuP + dessert + 2.5;
            Console.WriteLine(finalP);
        }
    }
}
