using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main() {
    Rectangle test = new Rectangle();
    Rectangle test2 = new Rectangle(5,6);
    Console.WriteLine("Height: " + test.GetHeight() + "\nWidth: " + test.GetWidth() + "\nArea: " + test.GetArea() + "\nPerimeter: " + test.GetPerimeter());
    Console.WriteLine();
    Console.WriteLine("Height 2: " + test2.GetHeight() + "\nWidth 2: " + test2.GetWidth() + "\nArea 2: " + test2.GetArea() + "\nPerimeter 2: " + test2.GetPerimeter());
  }
}