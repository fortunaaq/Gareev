﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program
    {
        public static void Main()
        {
            Random r = new Random();
            int number = r.Next(1, 2);
            int number1 = r.Next(1, 2);
            int i = 0;
            int t = 0;
            int n = 1;

            while ((i == 0) || (t >= n))
            {
                t++;
                int try1 = Convert.ToInt32(Console.ReadLine());
                if ((try1 == number) || (try1 == number1))
                {
                    Console.WriteLine("Вы угадали число с " + t + " попытки!");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Вы не угадали число");
                }
            }
            if (t == n)
            {
                Console.WriteLine("Вы проиграли");
            }

        }
    }
}