using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstathletetime = int.Parse(Console.ReadLine());
            int secondathletetime = int.Parse(Console.ReadLine());
            int thirdathletetime = int.Parse(Console.ReadLine());
            int totalsecond = firstathletetime + secondathletetime + thirdathletetime;
            int minutes = totalsecond/60;
            int seconds = totalsecond%60;
            
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
