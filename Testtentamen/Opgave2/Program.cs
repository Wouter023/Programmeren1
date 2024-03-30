namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            do
            {
                Console.WriteLine("Geef een getal:");
                number = int.Parse(Console.ReadLine());
                int amountOfStars = number / 2;
                string output = "";

                for (int i = 0; i < amountOfStars; i++)
                {
                    output += "*";
                }
                for (int i = amountOfStars; i < number; i++)
                {
                    output += "!";
                }
                Console.WriteLine(output);
            }while (number > 0);
        }
    }
}