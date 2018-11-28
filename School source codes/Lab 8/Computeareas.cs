using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static double SquareArea (double x) {
    double k = x*x;
    return k;
  }
  public static double RectArea (double x,double y) {
    double k = x*y;
    return k;
  }
  public static double CircleArea (double x) {
    double k = (Math.PI)*(x*x);
    return k;
  }
  public static double TriArea (double x, double y) {
    double k = (x*y)/2;
    return k;
  }
  public static void Main (string[] args) {
    int square,rect1,rect2,circle,tri1,tri2;
    Console.Write("enter your square side length: ");
    square = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Square's area: " + SquareArea(square));
    Console.WriteLine();
    Console.Write("enter your rectangle side width: ");
    rect1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter your rectangle side height: ");
    rect2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Rectangles area: " + RectArea(rect1,rect2));
    Console.WriteLine();
    Console.Write("enter your circle radius: ");
    circle = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Circle's area: " + CircleArea(circle));
    Console.WriteLine();
    Console.Write("enter your triangle base: ");
    tri1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter your triangle height: ");
    tri2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tirangle's area: " + TriArea(tri1,tri2));
  }
}