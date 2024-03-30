namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[20];

            int numberOfOccurences = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine($"Enter a number (0=stop): ");
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    break;
                }
                else
                {
                    elements[i] = input;
                }
            }

            Console.WriteLine($"Enter a searchvalue: ");
            int searchValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < elements.Length; i++)
            {
                if (searchValue == elements[i])
                {
                    numberOfOccurences++;
                }
            }

            Console.WriteLine($"Number of occurences of searchvalue ({searchValue}) is: {numberOfOccurences}");
        }
    }
}