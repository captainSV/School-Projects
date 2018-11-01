using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int grade1,grade2,grade3,grade4,grademax,grademin;
    double gradeaverage;
    Console.WriteLine ("Enter your grades: ");
    grade1 = Convert.ToInt32(Console.ReadLine());
    grade2 = Convert.ToInt32(Console.ReadLine());
    grade3 = Convert.ToInt32(Console.ReadLine());
    grade4 = Convert.ToInt32(Console.ReadLine());
    int[] gradearray = {grade1,grade2,grade3,grade4};
    grademin = gradearray.Min();
    grademax = gradearray.Max();
    gradeaverage = (grade1 + grade2 + grade3 + grade4)/4;
    Console.WriteLine("You entered: " +grade1 + ", " + grade2 + ", " + grade3 + ", " + grade4);
    Console.WriteLine("Highest grade: " + grademax);
    Console.WriteLine("Lowest grade: " + grademin);
    Console.WriteLine("Average grade: " + gradeaverage);
  }
}