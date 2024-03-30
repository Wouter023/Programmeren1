namespace Opgave3
{
    internal class Program
    {
        const int AmountOfNumbers = 20;
        static void Main(string[] args)
        {
            //Make array
            int[] numbers = new int[AmountOfNumbers];
            Random random = new Random();

            //Generate random numbers in list
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            //Get highest and lowest value in array
            int highestValue = numbers.Max();
            int lowestValue = numbers.Min();

            //print highest and lowest value
            Console.WriteLine($"lowest value: {lowestValue}\nhighest value: {highestValue}");
            string output = "";

            for(int i = 0; i < numbers.Length; i++)
            {
                //check for differnce
                if (numbers[i] < (lowestValue + 10) || numbers[i] > (highestValue - 10))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if(numbers[i] < (lowestValue + 20) || numbers[i] > (highestValue - 20))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                
                //Print number with color
                Console.Write($"{numbers[i]} ");
                Console.ResetColor();
            }

        }
    }
}