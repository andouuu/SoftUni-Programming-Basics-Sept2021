using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaKv = 7.61;
            double kvM = double.Parse(Console.ReadLine());
            double cena = cenaKv * kvM;
            double otstupka = cena * 18 / 100;
            double krainaC = cena - otstupka;
            Console.WriteLine($"The final price is: {krainaC}");
            Console.WriteLine($"The discount is: {otstupka}");
        }
    }
}
