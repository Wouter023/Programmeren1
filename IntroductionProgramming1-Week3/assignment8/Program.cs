using System.Globalization;

namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //get data
            Console.WriteLine("Enter number of working hours: ");
            int numberOfWorkingHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of years: ");
            int numberOfYears = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of failures: ");
            int numberOfFailures = int.Parse(Console.ReadLine());

            //compare data
            if(numberOfWorkingHours > 10000 || numberOfYears >= 7 || numberOfFailures > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }
        }
    }
}