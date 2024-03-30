using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        const float VatRate = 0.21f;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter the price: ");
            float basePrice = float.Parse(Console.ReadLine());

            float vatPrice = CalculateVat(basePrice);
            float totalPrice = CalcTotalPrice(basePrice, vatPrice);

            Console.WriteLine("price: {0:0.00}, VAT: {1:0.00}, total: {2:0.00}", basePrice, vatPrice, totalPrice);
        }

        static float CalculateVat(float price)
        {
            float result = price * VatRate;
            return result;
        }

        static float CalcTotalPrice(float basePrice, float vatPrice)
        {
            return basePrice + vatPrice;
        }
    }
}