namespace VoorbeeldLes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTargetNumberEntered = 0;
            Console.WriteLine("Enter a target grade: ");
            int targetNumber = int.Parse(Console.ReadLine());

            bool inputIsZero = false;

            while (!inputIsZero)
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if(targetNumber == number)
                {
                    countOfTargetNumberEntered++;
                }
                if(number == 0)
                {
                    inputIsZero = true;
                }
            }

            Console.WriteLine("{0}", countOfTargetNumberEntered);
            Console.WriteLine("End of program");
        }
    }
}