using System.Globalization;

namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            double minBmiValue = 0, maxBmivalue = 0, minWeightRange, maxWeightRange;
            //ask for information
            Console.WriteLine("Enter weight (kg): ");
            double weightInKg = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter length (cm): ");
            double lengthInCm = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender (male/female): ");
            string gender = Console.ReadLine().ToLower();

            //calculate
            double bmiValue = weightInKg / ((lengthInCm/100)* (lengthInCm / 100)); 
            
            if(gender == "male")
            {
                minBmiValue = 20;
                maxBmivalue = 25;
            }
            else if(gender == "female")
            {
                minBmiValue = 19;
                maxBmivalue = 24;
            }

            minWeightRange = minBmiValue * ((lengthInCm / 100) * (lengthInCm / 100));
            maxWeightRange = maxBmivalue * ((lengthInCm / 100) * (lengthInCm / 100));

            Console.WriteLine("bmi-value: {0:0.0}", bmiValue);
            Console.WriteLine("normal bmi-values (min..max): {0}..{1}", minBmiValue, maxBmivalue);
            Console.WriteLine("healthy weight range: {0:0.0} .. {1:0.0}", minWeightRange, maxWeightRange);
        }
    }
}