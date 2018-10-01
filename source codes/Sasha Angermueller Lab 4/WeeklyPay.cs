// Class:	CSE 1321L
// Section: 	08         
// Term:		Fall 2018  
// Instructor:	
// Name:		Sasha Angermueller
// Lab#:	    4

using System;

class WeeklyPay {
  public static void Main (string[] args) {
    int hours;
    double hourly,overtime,totalpaid;
    Console.WriteLine ("How many hours did you work?");
    hours = Convert.ToInt32(Console.ReadLine());
    hourly = 10;
    overtime = 15;
    if (hours > 40)
      {totalpaid = ((hours%40)*overtime)+400;}
    else
      {totalpaid = hours*hourly;}
    Console.WriteLine("Gross earning is $" + totalpaid);
    Console.ReadLine();
  }
}