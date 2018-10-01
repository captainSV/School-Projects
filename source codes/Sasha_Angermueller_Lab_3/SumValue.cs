// Class:	CSE 1321L
// Section: 	08         
// Term:		Fall 2018  
// Instructor:	
// Name:		Sasha Angermueller
// Lab#:	    3


using System;

class SumValue {
  public static void Main (string[] args) {
    double Average, XValue, YValue, ZValue; //initialize variables
    Console.WriteLine ("What is the X value?");
    XValue = double.Parse(Console.ReadLine()); //gets user input
    Console.WriteLine ("What is the Y value?");
    YValue = double.Parse(Console.ReadLine());
    Console.WriteLine ("What is the Z value?");
    ZValue = double.Parse(Console.ReadLine());
    Average = ((XValue)+(YValue)+(ZValue))/3; //calculate average
    Console.WriteLine ("Average = " + Average);
    Console.ReadLine();
  }
}