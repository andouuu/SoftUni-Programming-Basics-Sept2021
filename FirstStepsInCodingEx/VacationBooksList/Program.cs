using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesperhour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hoursperday = pages / pagesperhour / days;
            Console.WriteLine(hoursperday);
        }
    }
}
