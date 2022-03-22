using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1Nums = 0;
            double p2Nums = 0;
            double p3Nums = 0;
            double p4Nums = 0;
            double p5Nums = 0;
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1Nums += 1;
                }
                else if (num >= 200 && num < 400)
                {
                    p2Nums += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    p3Nums += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    p4Nums += 1;
                }
                else
                {
                    p5Nums += 1;
                }
            }
            double p1 = p1Nums/n*100;
            double p2 = p2Nums/n*100;
            double p3 = p3Nums/n*100;
            double p4 = p4Nums/n*100;
            double p5 = p5Nums/n*100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
