using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //set doubles
            double countOfPostitiveNumbersEntered = 0;
            double totalSumOfNumbers = 0;
            double averageOfAllPositiveNumbers = 0;

            bool inputIsZero = false;

            while (!inputIsZero)
            {
                Console.WriteLine("Enter a number: ");
                double number = double.Parse(Console.ReadLine());

                if (number > 0)
                {
                    totalSumOfNumbers += number;
                    countOfPostitiveNumbersEntered++;
                    averageOfAllPositiveNumbers = totalSumOfNumbers / countOfPostitiveNumbersEntered;
                }

                if(number == 0)
                {
                    inputIsZero = true;
                }
            }

            Console.WriteLine($"Average of all positive numbers is: {averageOfAllPositiveNumbers:0.00}");
        }
    }
}