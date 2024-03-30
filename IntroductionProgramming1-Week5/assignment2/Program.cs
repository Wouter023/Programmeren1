namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] elements = new int[20];

            int numberOfOccurences = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = random.Next(0, 150);
                Console.WriteLine($"Element {i} = {elements[i]}");
            }

            int smallestNumber = elements.Min();

            for (int i = 0; i < elements.Length; i++)
            {
                if(smallestNumber == elements[i])
                {
                    numberOfOccurences++;
                }
            }

            Console.WriteLine($"smallest number = {smallestNumber}\nnumber of occurence = {numberOfOccurences}");
        }
    }
}