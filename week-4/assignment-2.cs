﻿using System;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1 Write a program in C# to make a pattern like a right triangle with the number increased by 1//
            //initial try - literal print of numbers 1-10//
            /*int num = 1;
            while(num < 2)
            {
                Console.WriteLine(num);
                num++;
            }
            while(num < 4)
            {
                Console.Write(num);
                num++;
                Console.WriteLine(num);
                num++;
            }
            while(num < 7)
            {
                Console.Write(num);
                num++;
                Console.Write(num);
                num++;
                Console.WriteLine(num);
                num++;
            }
            while(num < 11)
            {
                Console.Write(num);
                num++;
                Console.Write(num);
                num++;
                Console.Write(num);
                num++;
                Console.WriteLine(num);
                num++;
            }
            Console.ReadLine();*/

            //now want to solve this for any numbers not just those specified - DRY code//
            int value = 1;
            //n will be the number of lines returned in the output//
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(value);
                    value++;
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            //2.2 Write a C# program to calculate a factorial of a given number//
            int m;
            Console.WriteLine("Enter the number for which you would like to calculate the factorial:");
            m = Convert.ToInt32(Console.ReadLine());

            for (int k = m-1; k >= 1; k--)
            {
                m = m * k;
            }
            Console.WriteLine(m);
            Console.ReadLine();

            //Now using recursion//
            int o;
            Console.WriteLine("Enter the number for which you would like to calculate the factorial:");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(o));
            Console.ReadLine();
        }

        static int Fact(int num) {
          if (num == 1) {
            return 1;
          }
          return num * Fact(num - 1);
        }
    }
}
