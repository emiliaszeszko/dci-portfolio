using System;

namespace functions_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a letter, any letter:");
            char x = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(VowelTest(Char.ToLower(x)));

            Console.WriteLine("Pick a number 1-10:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number 1-10:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a third number 1-10");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ReturnLargestInt(a,b,c));
        }

        static bool VowelTest(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int ReturnLargestInt(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
