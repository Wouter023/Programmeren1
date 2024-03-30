using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    internal class Program
    {
        const double VatRate = 0.21; 
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // 1. Read Price
            Console.Write("Enter the price: ");
            string input = Console.ReadLine();

            // Convert string to double
            double price = double.Parse(input);

            // 2. Calculate the Vat
            double vat = price * VatRate;

            // 3. Calculate the totalPrice
            double totalPrice = price + vat;

            // 4. Print the price, vat, totalPrice
            Console.WriteLine("price: {0:0.00}, VAT: {1:0.00}, total: {2:0.00}", price, vat, totalPrice);
        }
    }
}