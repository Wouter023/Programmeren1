namespace VoorbeeldLes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validGrade = false;

            //while(!validgrade)
            //{
            //    console.writeline("enter grade 1..10:");
            //    int grade = int.parse(console.readline());
            //    if(grade >= 1 && grade <= 10)
            //    {
            //        validgrade = true;
            //    } 
            //}

            do
            {
                Console.WriteLine("enter grade 1..10:");
                int grade = int.Parse(Console.ReadLine());
                if (grade >= 1 && grade <= 10)
                {
                    validGrade = true;
                }
            } while (!validGrade);

            Console.WriteLine("End of program");
        }
    }
}