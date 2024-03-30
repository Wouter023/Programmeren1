namespace LesVoorbeeld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputIsStop = false;
            int totalScore = 0;

            while (!inputIsStop)
            {
                Console.WriteLine("Enter a word: ");
                string word = Console.ReadLine().ToUpper();
                if (word == "STOP")
                {
                    inputIsStop = true;
                }
                int score = GetScoreFromWord(word);
                totalScore += score;
            }

            Console.WriteLine($"Totalscore: {totalScore}");
        }

        static int GetScoreFromWord(string word)
        {
            int totalScore = 0;

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] scores = new int[26] { 1, 4, 5, 2, 1, 4, 3, 4, 2, 4, 3, 3, 3, 1, 1, 4, 10, 2, 2, 2, 2, 4, 5, 8, 8, 5 };
            
            foreach (char c in word)
            {
                int index = alphabet.IndexOf(c);
                totalScore += scores[index];
            }

            return totalScore;
        }
    }
}