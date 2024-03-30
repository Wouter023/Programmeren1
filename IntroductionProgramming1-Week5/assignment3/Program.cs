using System.Globalization;
using System.Transactions;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.WriteLine($"Enter course name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine($"Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string[] names = new string[numberOfStudents];
            int[] grades = new int[numberOfStudents];

            int sumOfAllGrades = 0;
            int countOfAllGrades = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter name of student {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter grade of {names[i]}:");
                grades[i] = int.Parse(Console.ReadLine());
                sumOfAllGrades += grades[i];
                countOfAllGrades++;
            }

            double averageGrade = (double)sumOfAllGrades / countOfAllGrades;
            int highestGrade = grades.Max();
            int indexOfhighestGrade = grades.ToList().IndexOf(highestGrade);

            Console.WriteLine($"Average grade: {averageGrade:0.0}\nStudent {names[indexOfhighestGrade]} has highest grade: {highestGrade}");

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Grade for student {names[i]} (course {courseName}): {grades[i]}");
            }
        }
    }
}