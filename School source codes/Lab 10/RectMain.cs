using System;
using System.Collections.Generic;
using System.Linq;

public class Rectangle {
  public Rectangle() {
    height = 1;
    width = 1;
  }
  public Rectangle(double name, double test) {
    height = name;
    width = test;
  }
  private double height {get;set;}
  private double width {get;set;}
  public double GetArea() {
    double _area = height * width;
    return _area;
  }
  public double GetPerimeter() {
    double _perm = (height*2) + (width*2);
    return _perm;
  }
  public double GetHeight() {
    double _height = height;
    return _height;
  }
  public double GetWidth() {
    double _width = width;
    return _width;
  }
}

class MainClass {
  public static void Main() {
    Rectangle test = new Rectangle();
    Rectangle test2 = new Rectangle(5,6);
    Console.WriteLine("Height: " + test.GetHeight() + "\nWidth: " + test.GetWidth() + "\nArea: " + test.GetArea() + "\nPerimeter: " + test.GetPerimeter());
    Console.WriteLine();
    Console.WriteLine("Height 2: " + test2.GetHeight() + "\nWidth 2: " + test2.GetWidth() + "\nArea 2: " + test2.GetArea() + "\nPerimeter 2: " + test2.GetPerimeter());
  }
}