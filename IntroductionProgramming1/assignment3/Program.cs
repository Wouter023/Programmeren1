using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for first name
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();

            //Ask user for last name
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();

            //Show first and last name in different ways
            Console.WriteLine("Your full name is " + firstname + " " + lastname);
            Console.WriteLine("Your full name is {0} {1}", firstname, lastname);
            Console.WriteLine($"Your full name is {firstname} {lastname}");
        }
    }
}