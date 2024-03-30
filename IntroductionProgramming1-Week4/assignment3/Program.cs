namespace assignment3
{
    internal class Program
    {
        const int EveryFifthNumber = 5;
        static void Main(string[] args)
        {
            int sumOfEveryFifthNumber = 0;
            int countNumberEnterd = 0;

            bool inputIsZero = false;

            while (!inputIsZero)
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                countNumberEnterd++;

                if(countNumberEnterd % EveryFifthNumber == 0)
                {
                    sumOfEveryFifthNumber += number;
                }
                if(number == 0)
                {
                    inputIsZero = true;
                }
            }

            Console.WriteLine($"Sum of 5th, 10th, 15th, ... number is: {sumOfEveryFifthNumber}");
        }
    }
}