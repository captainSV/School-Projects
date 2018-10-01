// Class:	CSE 1321L
// Section: 	08         
// Term:		Fall 2018  
// Instructor:	
// Name:		Sasha Angermueller
// Lab#:	    4

using System;

class GradeReport {
  public static void Main (string[] args) {
    int grade, switchvalue;
    Console.WriteLine ("What was your grade on the test?");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade > 99)
      {switchvalue = 1;}
    else if (grade/10 == 9)
      {switchvalue = 2;}
    else if (grade/10==8)
      {switchvalue = 3;}
    else if (grade/10==7)
      {switchvalue = 4;}
    else if (grade/10==6)
      {switchvalue = 5;}
    else
      {switchvalue = 6;}
    switch (switchvalue)
      {
        case 1:
          Console.WriteLine("That grade is a perfect score. Well done.");
          break;
        case 2:
          Console.WriteLine("That grade is well above average. Excellent work.");
          break;
        case 3:
          Console.WriteLine("That grade is above average. Nice job.");
          break;
        case 4:
          Console.WriteLine("That is average work.");
          break;
        case 5:
          Console.WriteLine("That grade is not good, you should seek help!");
          break;
        case 6:
          Console.WriteLine("That grade is not passing.");
          break;
        default:
          Console.WriteLine("Something went horriably, horriably wrong!");
          break;
      }
  }
}