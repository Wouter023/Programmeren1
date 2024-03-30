namespace assignment5
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

                if(year == 0)
                {
                    numberIsZero = true;
                }
                else if(year < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
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
}