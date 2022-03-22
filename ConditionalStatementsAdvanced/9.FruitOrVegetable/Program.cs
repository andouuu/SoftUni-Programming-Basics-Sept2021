using System;

namespace _9.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Плодовете fruit  имат следните възможни стойности: banana, apple, kiwi, cherry, lemon и grapes
            // Зеленчуците vegetable  имат следните възможни стойности: tomato, cucumber, pepper и carrot
            // Всички останали са unknown
            string plant = Console.ReadLine();
            switch (plant)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
