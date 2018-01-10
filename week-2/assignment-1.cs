using System;

namespace first_project_visual_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Assignment 1 Problem #1 if else if else statement:
            int m;

            Console.Write("Input any integer:");
            m = Convert.ToInt32(Console.ReadLine());

            if (m < 0)
            {
                Console.WriteLine("Value of n is -1");
            }
            else if (m == 0)
            {
                Console.WriteLine("Value of n is 0");
            }
            else if (m > 0)
            {
                Console.WriteLine("Value of n is 1");
            }
            //Attempting exception handling but needs work - what if input is not an integer?
            else
            {
                Console.WriteLine("Please input an integer");
            }

            //Problem #2 if else if else:
            int maths, phys, chem;

            Console.Write("What was your maths score?");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("What was your phys score?");
            phys = Convert.ToInt32(Console.ReadLine());
            Console.Write("What was your chem score?");
            chem = Convert.ToInt32(Console.ReadLine());

            if (maths >= 65)
            {
                if (phys >= 55)
                {
                    if (chem >= 50)
                    {
                        Console.WriteLine("Accepted");
                    }
                }
            }
            else if (maths + phys + chem >= 180)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Denied");
            }
            //why did we add the following line below?
            //Console.ReadLine();

            //Problem #3 Conditional Loops - using while loop
            int num = 0;
            while (++num < 11)
                Console.WriteLine(num);
        }
    }
}