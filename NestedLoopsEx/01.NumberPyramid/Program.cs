﻿using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    if (current>num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                if (isBigger)
                {
                    break;

                }
                Console.WriteLine();
            }
        }
    }
}
