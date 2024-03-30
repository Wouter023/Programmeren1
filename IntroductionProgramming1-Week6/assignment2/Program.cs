namespace assignment2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                bool isPrime = IsPrimeNumber(number);

                if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else
                {
                    if (isPrime)
                    {
                        Console.WriteLine("{0} is a prime number.", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a prime number.", number);
                    }      
                }
                
                number = int.Parse(Console.ReadLine());
            }
        }

        static bool IsPrimeNumber(int number)
        {
            bool isPrimeNumber = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrimeNumber = false;
                }
            }

            return isPrimeNumber;
        }
    }
}