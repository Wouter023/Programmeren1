namespace Opgave4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool numberIsZero = false;

            while (!numberIsZero)
            {
                int number = random.Next(10);
                if(number == 0)
                {
                    numberIsZero = true;
                }
                else
                {
                    int facultyOfNumber = Faculteit(number);
                    Console.WriteLine($"Faculteit van {number} is {facultyOfNumber}");
                }
            }
        }

        static int Faculteit(int getal)
        {
            int result = 1;

            for (int i = 2; i <= getal; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}