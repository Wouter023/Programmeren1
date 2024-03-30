using System.Globalization;

namespace Opgave1
{
    internal class Program
    {
        //make const price
        const double VolledigCollegegeld = 2209.00;
        const double HalfCollegegeld = VolledigCollegegeld / 2;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            string output = "het collegegeld voor dit collegejaar is ";
            
            //ask user for name
            Console.WriteLine("geef je naam: ");
            string name = Console.ReadLine();

            //ask user for bacholor
            Console.WriteLine($"{name}, is dit je eerste bacholor opleiding?");
            //answer to lowercase
            string answerFirstQuestion = Console.ReadLine().ToLower();

            
            if(answerFirstQuestion == "ja")
            {
                output += $"de helft ({HalfCollegegeld:0.00}), ";

                //ask for lerarenopleiding
                Console.WriteLine("is het een lerarenopleiding?");
                //answer to lowercase
                string answerSecondQuestion = Console.ReadLine().ToLower();

                if(answerSecondQuestion == "nee")
                {
                    output += $"en volgend jaar ook de helft";
                }
                else if(answerSecondQuestion == "ja"){
                    output += $"daarna volledig";
                }
            }
            else if(answerFirstQuestion == "nee")
            {
                output += $"volledig ({VolledigCollegegeld:0.00})";
            }
            //print output
            Console.WriteLine(output);
        }
    }
}