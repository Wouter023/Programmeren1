using System;
using System.Security.Authentication.ExtendedProtection;

namespace LesVoorbeeld1
{
    internal class Program
    {
        //Set gravity
        const double gravity = 9.81;

        static void Main(string[] args)
        {
            //Get weight in KG
            Console.Write("Give the mass of a object in Kg: ");
            string input = Console.ReadLine();

            //Convert string in double
            double massInKg = Double.Parse(input);

            //Calculate force on earth
            double forceOnEarthInNewton = massInKg * gravity;

            //Display force
            Console.WriteLine("Force on earth: {0} Newton", forceOnEarthInNewton);
            Console.ReadKey();
        }
    }
}