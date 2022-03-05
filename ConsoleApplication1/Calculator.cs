using System;

namespace ConsoleApplication1
{
    internal static class Calculator
    {
        public static void Main(string[] Args)
        {
            var inputValid = false;

            var number = 0;

            string operation;

            Console.WriteLine("Please input an operation. +,-,* or / are valid");

            do
            {
                operation = Console.ReadLine()?.Trim();

                if (operation == "+")
                {
                    Console.WriteLine("Current value is: " + number);
                    
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine("Please input a valid operation.");
                }
            } while (!inputValid);

        }
    }
}