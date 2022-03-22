using System;

namespace _4.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            switch (sex)
            {
                case 'm':
                    if (age >= 16) { Console.WriteLine("Mr."); }
                    else { Console.WriteLine("Master"); }
                    break;
                case 'f':
                    if (age >= 16) { Console.WriteLine("Ms."); }
                    else { Console.WriteLine("Miss"); }
                    break;
                    
            }
        }
    }
}
