using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първият ред съдържа час на изпита – цяло число от 0 до 23.
            // Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            // Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            // Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int testHour = int.Parse(Console.ReadLine());
            int testMins = int.Parse(Console.ReadLine());
            int hourCame = int.Parse(Console.ReadLine());
            int minsCame = int.Parse(Console.ReadLine());
            testHour = testHour * 60;
            hourCame = hourCame * 60;
            double difference = ((testMins + testHour) - (hourCame + minsCame));
            if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference > 30)
            {
                if (difference >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{Math.Truncate(difference / 60)}:{difference%60:00} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                
            }
            else
            {
                if (difference <= -60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Truncate(Math.Abs(difference / 60))}:{Math.Abs(difference % 60):00} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
            }
        }
    }
}
