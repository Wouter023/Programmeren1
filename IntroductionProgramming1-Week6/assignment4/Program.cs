namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrOfFullStops, nrOfCommas, nrOfSemiColons;

            Console.WriteLine("Enter a text");
            string input = Console.ReadLine();

            SearchText(input, out nrOfFullStops, out nrOfCommas, out nrOfSemiColons);
            Console.WriteLine($"result: {nrOfFullStops} full stops, {nrOfCommas} commas, {nrOfSemiColons} semicolons");
        }

        static void SearchText(string input, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = 0;
            nrOfCommas = 0;
            nrOfSemiColons = 0;

            foreach (char c in input)
            {
                if(c == '.')
                {
                    nrOfFullStops++;
                }
                if (c == ',')
                {
                    nrOfCommas++;
                }
                if(c == ';')
                {
                    nrOfSemiColons++;
                }
            }
        }
    }
}