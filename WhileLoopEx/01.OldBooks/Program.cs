using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string searchedBook = Console.ReadLine();
            int counter = 0;
            while (searchedBook != book)
            {
                if(searchedBook=="No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter += 1;
                searchedBook = Console.ReadLine();
            }
            if (searchedBook != "No More Books")
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
