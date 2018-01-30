using System;

namespace csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        //while loop
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            Console.ReadLine();
        }
        //do while loop
        private static void DoWhileTest()
        {
            int i = 1;
            do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
            Console.ReadLine();
        }
        //for loop
        private static void ForTest()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
            Console.ReadLine();
        }
    }
}
