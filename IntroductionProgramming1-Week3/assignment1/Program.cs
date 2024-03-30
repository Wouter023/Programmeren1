namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Highest value is: {0}\nLowest value is: {1}", firstNumber, secondNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Highest value is: {0}\nLowest value is: {1}", secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("Highest value is: {0}\nLowest value is: {1}", firstNumber, firstNumber);
            }
        }
    }
}