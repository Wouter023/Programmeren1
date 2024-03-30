namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            //Calculate if third number is lowest
            if(thirdNumber < firstNumber && thirdNumber < secondNumber)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }
        }
    }
}