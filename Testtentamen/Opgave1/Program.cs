namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordFromEndToStart = "";

            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                wordFromEndToStart += word[i];
            }

            if(wordFromEndToStart == word)
            {
                Console.WriteLine($"{wordFromEndToStart} palingdroom");
            }
            else
            {
                Console.WriteLine($"{wordFromEndToStart} geen palingdroom");
            }
        }
    }
}