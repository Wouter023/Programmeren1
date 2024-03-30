namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if(firstNumber % secondNumber == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if(secondNumber % firstNumber == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
        }
    }
}