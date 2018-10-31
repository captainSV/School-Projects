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