using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyprice = int.Parse(Console.ReadLine());
            
            double shoes =yearlyprice- yearlyprice * 0.4;
            double clothes = shoes - shoes * 0.2;
            double ball = clothes / 4;
            double accessories = ball / 5;
            double moneyneeded = yearlyprice + shoes + clothes + ball + accessories;
            Console.WriteLine(moneyneeded);
        }
    }
}
