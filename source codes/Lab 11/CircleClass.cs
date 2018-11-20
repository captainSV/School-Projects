using System;
using System.Collections.Generic;
using System.Linq;

public class Circle {
  private double radius {get;set;}
  public Circle(){
    radius = 1;
  }
  public Circle(int init){
    radius = init;
  }
  public void SetRadius(int a)
    {radius = a;}

  public double GetRadius()
    {return radius;}
  public double GetArea()
    {return (radius*radius)*Math.PI;}
  public double GetPerimeter()
    {return Math.PI*2*radius;}

  public override string ToString() {
    return "The circle has radius " + radius;
  }
}