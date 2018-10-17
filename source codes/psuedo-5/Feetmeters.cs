using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static double feet2meter(double x){
    return 0.305*x;
  }
  public static double meter2feet(double y){
    return 3.279*y;
  }
  public static void Main (string[] args) {
    int counter = 1;
    Console.Write("Feet   ");
    Console.Write("Meter  ");
    Console.Write("Meter   ");
    Console.WriteLine("Feet  ");
    while (counter < 10) {
    Console.Write(counter +"      ");
    Console.Write(feet2meter(counter)+ "   ");
    Console.Write(counter + "      ");
    Console.WriteLine(meter2feet(counter)+ "   ");
    counter++;
    }
    while (counter > 9 && counter < 21) {
    Console.Write(counter +"     ");
    Console.Write(feet2meter(counter)+ "   ");
    Console.Write(counter + "     ");
    Console.WriteLine(meter2feet(counter)+ "   ");
    counter++;
    }
  }
}