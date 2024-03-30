using System.Globalization;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //Get user input
            //Console.WriteLine("Enter first number: ");
            double firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            double secondNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter third number: ");
            double thirdNumber = int.Parse(Console.ReadLine());

            //Calculations with numbers
            double sum = firstNumber + secondNumber + thirdNumber;

            double average = (firstNumber + secondNumber + thirdNumber) /3;

            double product = firstNumber * secondNumber * thirdNumber;

            double lowestNumber = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);

            double highestNumber = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine($"sum = {sum}\naverage = {average:0.00}\nproduct = {product}\nhighest = {highestNumber}\nlowest = {lowestNumber}");
        }
    }
}