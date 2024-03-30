namespace assignment2
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

                if (targetNumber == number)
                {
                    countOfTargetNumberEntered++;
                }
                if (number == 0)
                {
                    inputIsZero = true;
                }
            }

            Console.WriteLine("Count of numbers equal to target number: {0}", countOfTargetNumberEntered);
        }
    }
}