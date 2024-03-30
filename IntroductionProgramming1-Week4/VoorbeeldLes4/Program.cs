namespace VoorbeeldLes4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while(number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("End of Program");
        }
    }
}