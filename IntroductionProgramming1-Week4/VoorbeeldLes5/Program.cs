namespace VoorbeeldLes5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int devider = 2;

            while((number < devider) && isPrime)
            {
                if(number % devider == 0)
                {
                    isPrime = false;
                }
                devider++;
            }

            if (isPrime)
            {
                Console.WriteLine("{0} is prime", number);
            }
            else
            {
                Console.WriteLine("{0} is not prime", number);
            }
        }
    }
}