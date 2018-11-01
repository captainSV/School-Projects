// Class:	CSE 1321L
// Section: 	08         
// Term:		Fall 2018  
// Instructor:	
// Name:		Sasha Angermueller
// Lab#:	    4

using System;

class Youth {
  public static void Main (string[] args) {
    int Age;
    Console.WriteLine ("What's your age?");
    Age = Convert.ToInt32(Console.ReadLine());
    if (Age < 22)
      {Console.WriteLine("Youth is a wonderful thing. Enjoy");}
    Console.WriteLine("Age is a state of mind.");
    Console.ReadLine();
  }
}