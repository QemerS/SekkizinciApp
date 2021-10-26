using System;

namespace SekkizinciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a C# program that takes (with Console.ReadLine() method) a number
            and width also a number, as input and then displays a triangle of that width,using that number.
             */

            Console.WriteLine("Enter a number"); int number =  Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the desired width"); int width = Convert.ToInt32( Console.ReadLine());

            while (width >= 0)
            {
                Console.WriteLine();
                for (int a = width; a > 0; a--)
                {
                    Console.Write((Convert.ToString(number)));
                }
                width--;
            }
        }
    }
}
