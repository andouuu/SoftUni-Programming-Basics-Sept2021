using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrKuche = int.Parse(Console.ReadLine());
            double cenakuche = hrKuche * 2.5;
            int hrKotka = int.Parse(Console.ReadLine());
            int cenakotka = hrKotka * 4;
            double obshto = cenakotka + cenakuche;
            Console.WriteLine($"{obshto} lv.");
        }
    }
}
