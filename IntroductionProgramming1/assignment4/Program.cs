using System;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user for number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            //Do calculations with number
            int result = number + number;
            result = result + 10;
            result /= 2;
            result -= number;

            //show result
            Console.WriteLine($"result is {result}");
        }
    }
}