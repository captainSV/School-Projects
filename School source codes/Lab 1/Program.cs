using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade1, grade2, grade3, GradeAverage;
            string username;
            Console.Write("What is your name?");
            username = Console.ReadLine();
            Console.Write("What was your first grade?");
            Int32.TryParse(Console.ReadLine(), out grade1);
            Console.Write("What was your second grade?");
            Int32.TryParse(Console.ReadLine(), out grade2);
            Console.Write("What was your third grade?");
            Int32.TryParse(Console.ReadLine(), out grade3);
            GradeAverage = (grade1+grade2+grade3)/3;
            Console.Write("Your average is " + GradeAverage + " !");
            Console.ReadLine();
        }
    }
}
