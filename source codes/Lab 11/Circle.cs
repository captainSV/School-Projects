using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main() {
    Circle test = new Circle();
    Console.WriteLine(test);
    Console.WriteLine("Area is: " + test.GetArea());
    Console.WriteLine("Perimeter is: " + test.GetPerimeter());
    test.SetRadius(10);
    Console.WriteLine("\n");
    Console.WriteLine(test);
    Console.WriteLine("Area is: " + test.GetArea());
    Console.WriteLine("Perimeter is: " + test.GetPerimeter());
  }
}