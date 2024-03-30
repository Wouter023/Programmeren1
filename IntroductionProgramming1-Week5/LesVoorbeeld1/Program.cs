namespace LesVoorbeeld1
{
    internal class Program
    {
        const int NumberOfMonths = 12;

        static void Main(string[] args)
        {
            string[] monthNames = {"Jan", "Feb", "Mrt", "Apr", "Mei", "Jun", "Jul", "Aug", "Sep", "Okt", "Nov", "Dec"};

            double[] profit = new double[NumberOfMonths];
            double total = 0;

            for(int i = 0; i < profit.Length; i++)
            {
                Console.WriteLine($"Enter profit for {monthNames[i]} :");
                profit[i] = double.Parse(Console.ReadLine());
                total += profit[i];
            }

            double average = total / NumberOfMonths;

            for (int i = 0; i < profit.Length; i++)
            {
                if (profit[i] > average){
                    Console.WriteLine($"{monthNames[i]}: {profit[i]}");
                }
            }
        }
    }
}