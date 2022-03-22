using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int fMinutes = minutes + 15;
            if (fMinutes>=60)
            {
                hours =hours+ 1;
                fMinutes =fMinutes- 60;
            }
            if(hours>=24)
            {
                hours = hours - 24;
            }
            Console.WriteLine($"{hours}:{fMinutes:d2}");
        }
    }
}
