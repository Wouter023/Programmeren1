using System;
using System.Globalization;
using System.Threading;


namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //Ask for 3 number
            Console.WriteLine("Enter number 1: ");
            string inputNumber1 = Console.ReadLine();

            Console.WriteLine("Enter number 2: ");
            string inputNumber2 = Console.ReadLine();

            Console.WriteLine("Enter number 3: ");
            string inputNumber3 = Console.ReadLine();

            double firstNumber = double.Parse(inputNumber1);
            double secondNumber = double.Parse(inputNumber2);
            double thirdNumber = double.Parse(inputNumber3);

            //Sum the 3 number
            double totalAmount = firstNumber + secondNumber + thirdNumber;

            //Devide by 3
            double average = totalAmount / 3;

            //Print number 
            Console.WriteLine("The average is: {0}", average);
        }
    }
}