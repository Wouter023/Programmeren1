namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score: ");
            int amountOfPoints = int.Parse(Console.ReadLine());

            string grade;

            switch (amountOfPoints)
            {
                case int n when (amountOfPoints >= 90 && amountOfPoints <= 100):
                    grade = "A";
                    break;
                case int n when (amountOfPoints >= 80 && amountOfPoints <= 89):
                    grade = "B";
                    break;
                case int n when (amountOfPoints >= 70 && amountOfPoints <= 79):
                    grade = "C";
                    break;
                case int n when (amountOfPoints >= 60 && amountOfPoints <= 69):
                    grade = "D";
                    break;
                case int n when (amountOfPoints < 60 && amountOfPoints > 0):
                    grade = "F";
                    break;
                default:
                    grade = "I";
                    break;
            }

            if(grade == "A" || grade == "B" || grade == "C")
            {
                Console.WriteLine("grade: {0}", grade);
                Console.WriteLine("course passed");
            }
            else if(grade == "D" || grade == "F")
            {
                Console.WriteLine("grade: {0}", grade);
                Console.WriteLine("course not passed");
            }
            else if(grade == "I")
            {
                Console.WriteLine("Invalid grade");
            }
        }
    }
}