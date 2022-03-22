using System;

namespace _06.OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol=Console.ReadLine();
            double result = 0;
            switch (symbol)
            {
                case "+":
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                    break;
                case "/":
                    
                    if (n2 != 0)
                    {result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case "%":
                   
                    if (n2 != 0)
                    { result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");

                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
            }
        }
    }
}
