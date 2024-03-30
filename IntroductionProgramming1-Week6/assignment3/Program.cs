namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numberIsZero = false;
            
            while (!numberIsZero)
            {
                Console.WriteLine("Enter a year: ");
                int year = int.Parse(Console.ReadLine());
                bool isLeapYear = IsLeapYear(year);

                if (year == 0)
                {
                    numberIsZero = true;
                }
                else if (year < 0)
                {
                    Console.WriteLine("Negative year entered...");
                }
                else
                {
                    if (isLeapYear)
                    {
                        Console.WriteLine($"{year} is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is not a leap year.");
                    }
                }
            }
        }

        static bool IsLeapYear(int year)
        {
            bool isLeap = false;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isLeap = true;
            }
            else
            {
                isLeap = false;
            }

            return isLeap;
        }
    }
}