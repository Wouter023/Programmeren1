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

            int[] numbers = new int[20];
            int sumOfAllNumbers = 0;
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 201);
                sumOfAllNumbers += numbers[i];
                Console.WriteLine($"Element {i} is {numbers[i]}");
                count++;
            }

            double averageOfAllNumbers = (double)sumOfAllNumbers / count;
            Console.WriteLine($" The average is: {averageOfAllNumbers:0.00}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Difference between average and element {i} is {Math.Abs(numbers[i] - averageOfAllNumbers) :0.00}");
            }
        }
    }
}