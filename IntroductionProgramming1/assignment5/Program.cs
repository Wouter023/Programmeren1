using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Generate 4 different numbers
            int number1 = rnd.Next(101, 10000);
            int number2 = rnd.Next(101, 10000);
            int number3 = rnd.Next(101, 10000);
            int number4 = rnd.Next(101, 10000);
            int total = number1 + number2 + number3 + number4;

            //Ask user for the answer
            Console.WriteLine("What is the result of: {0} + {1} + {2} + {3}?", number1, number2, number3, number4);
            string input = Console.ReadLine();
            int answer = int.Parse(input);

            //Check if answer is correct
            if(answer == total)
            {
                Console.WriteLine("Your answer is correct");
            }
            else
            {
                Console.WriteLine("Your answer is incorrect. The awnser was: {0}", total);
            }

            Console.ReadKey();
        }
    }
}