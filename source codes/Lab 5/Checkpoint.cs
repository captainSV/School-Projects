using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int xvalue,yvalue;
    Console.Write("X coordinate is: ");
    xvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y coordinate is: ");
    yvalue = Convert.ToInt32(Console.ReadLine());
    if (xvalue == 0) {
      if (yvalue == 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is the origin point");}
      else
        {Console.WriteLine("("+xvalue+","+yvalue+") is on the Y Axis");}}
    else if (xvalue > 0) {
      if (yvalue == 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is on the X Axis");}
      else if (yvalue > 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is in the first quadrant");}
      else if (yvalue < 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is in the fourth quadrant");}}
    else {
      if (yvalue == 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is on the X Axis");}
      else if (yvalue > 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is in the second quadrant");}
      else if (yvalue < 0)
        {Console.WriteLine("("+xvalue+","+yvalue+") is in the third quadrant");}}
  }
}