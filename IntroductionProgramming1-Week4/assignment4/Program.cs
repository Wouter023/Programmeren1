namespace assignment4
{
    internal class Program
    {
        const int FirstElement = 1;
        const int SecondElement = 1;
        static void Main(string[] args)
        {
            int firstNumber = FirstElement;
            int secondNumber = SecondElement;
            int nextNumber;

            Console.Write($"{firstNumber}, {secondNumber}");

            for (int i = 3; i <= 20; i++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write($", {nextNumber}");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }
}