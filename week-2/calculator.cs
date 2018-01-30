using System;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Assignment 2 Problem #1 Write a Menu-Driven Calculator Program
            int a, b, choice;

            Console.Write("Make a simple calculation with two integers:");
            Console.Write("\n\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Enter the first integer:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick from the following options:");
            Console.WriteLine("1 - Addition, 2 - Subtraction, 3 - Multiplication, 4 - Division");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            switch (choice)
            {
                case 1:
                    //Console.WriteLine(a+b);
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case 2:
                    //Console.WriteLine(a-b);
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case 3:
                    //Console.WriteLine(a*b);
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;
                case 4:
                    //Console.WriteLine(a/b);
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}
