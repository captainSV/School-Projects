using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static bool IsValid(double x, double y){
      if (x + y > 30)
        {return true;}
      return false;
  }
  public static double Area(double a, double b){
    double k;
    k = a*b; //area calculation
    return k;
  }
  public static double Perimeter(double c,double d){
    double k;
    k = (c*2)+(d*2); //perimeter calculation
    return k;
  }
  public static void Main (string[] args) {
    double enteredH, enteredW;
    Console.Write("Entered height: ");
    enteredH = Convert.ToInt32(Console.ReadLine());
    Console.Write("Entered width: ");
    enteredW = Convert.ToInt32(Console.ReadLine());
    if (IsValid(enteredH,enteredW) == false)
      {Console.WriteLine("This is invalid rectangle. Try again");}
    else {
      Console.WriteLine("Area: " + Area(enteredH,enteredW));
      Console.WriteLine("Perimeter: " + Perimeter(enteredH,enteredW));
      }
  }
}