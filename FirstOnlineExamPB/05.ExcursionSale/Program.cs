using System;

namespace _05.ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountSea = int.Parse(Console.ReadLine());
            int amountMountain = int.Parse(Console.ReadLine());

            int totalPrice = 0;
            string input = Console.ReadLine();
            bool isSoldSea = false;
            bool isSoldMountain = false;
            while (input!="Stop")
            { 
                        if (amountSea == 0)
                        {
                            isSoldSea = true;
                            
                        }

                        if (amountMountain == 0)
                        {
                            isSoldMountain = true;
                            
                        }
                
                switch (input)
                {
                    case "sea":
                        if (amountSea > 0)
                        {
                            amountSea -= 1;
                            totalPrice += 680;
                        }
                        break;
                    case "mountain":
                        if (amountMountain > 0)
                        {
                            amountMountain -= 1;
                            totalPrice += 499;
                        }
                        break;
                }
                        
                        

                if (isSoldSea==true&&isSoldMountain==true)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (amountMountain == 0 && amountSea == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {totalPrice} leva.");
        }
    }
}
