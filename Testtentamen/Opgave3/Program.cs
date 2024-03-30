namespace Opgave3
{
    internal class Program
    {
        const int ArraySize = 20;
        static void Main(string[] args)
        {
            string[] words = new string[ArraySize];

            bool wordIsEmpty = false;
            int index = 0;

            while (!wordIsEmpty && index < words.Length)
            {
                Console.WriteLine("Enter word: ");
                string word = Console.ReadLine();

                if (word.Length == 0)
                {
                    wordIsEmpty = true;
                }
                else
                {
                    words[index] = word;
                    index++;
                }
            }

            foreach (string word in words)
            {
                if (word != null)
                {
                    if (word.Length % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine(word);
                    Console.ResetColor();
                }
            }
        }
    }
}