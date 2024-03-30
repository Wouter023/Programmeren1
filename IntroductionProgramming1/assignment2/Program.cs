using System;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user for age
            //Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            //Convert input to int and add +1
            //int age = int.Parse(input);
            //age = age + 1;

            //Convert back to string en print for user
            //string output = age.ToString();
            string output = (int.Parse(input) + 1).ToString();
            Console.WriteLine("Next year you will be " + output + " years old");
        }
    }
}