using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;

            //Ask user for name
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            //Ask user for age
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();

            //Show the name and age of the user 
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
        }
    }
}