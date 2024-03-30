namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1..4): ");
            string input = Console.ReadLine();

            string output;

            switch (input)
            {
                case "1":
                    output = "clubs";
                    break;
                case "2":
                    output = "diamonds";
                    break;
                case "3":
                    output = "hearts";
                    break;
                case "4":
                    output = "spades";
                    break;
                default:
                    output = "Incorrect number!";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}