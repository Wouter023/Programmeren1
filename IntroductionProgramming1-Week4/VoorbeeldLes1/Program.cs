namespace VoorbeeldLes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            while (value != 0)
            {
                Console.WriteLine(value);
                value = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("End of program!");
        }
    }
}