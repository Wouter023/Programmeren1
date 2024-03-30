namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool inputIsLowerThenOne = false;

            while (!inputIsLowerThenOne)
            {
                Console.WriteLine("Voer een getal in: ");
                int number = int.Parse(Console.ReadLine());

                if(number < 1)
                {
                    inputIsLowerThenOne = true;
                }
                else
                {
                    int factor = 2;
                    while(number > 1)
                    {
                        if(number % factor == 0)
                        {
                            number = number / factor;
                            Console.Write($"{factor}");
                        }
                        else
                        {
                            factor++;
                        }
                    }
                }
            }
        }
    }
}