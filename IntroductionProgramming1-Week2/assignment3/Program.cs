using System;

namespace assignment3
{
    internal class Program
    {
        const int SecondsInHour = 3600;
        const int SecondsInMinute = 60;
        static void Main(string[] args)
        {
            //Get user input
            Console.Write("Enter number of seconds: ");
            string input = Console.ReadLine();

            int secondsAmount = int.Parse(input);

            //Convert input
            int amountOfHours = (secondsAmount / SecondsInHour);
            int amountOfMinutes = (secondsAmount % SecondsInHour) / SecondsInMinute;
            int amountOfSeconds = (secondsAmount % SecondsInHour) % SecondsInMinute;

            //Print time
            Console.WriteLine("{0:00}:{1:00}:{2:00}", amountOfHours, amountOfMinutes, amountOfSeconds);
        }
    }
}