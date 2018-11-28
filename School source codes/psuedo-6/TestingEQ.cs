using System;
using System.Collections.Generic;
using System.Linq;

public class QuadEq {
  public QuadEq(double at, double bat,double cat) {
    a = at;
    b = bat;
    c = cat;
  }
  private double a {get;set;}
  private double b {get;set;}
  private double c {get;set;}
  public double GetA() 
    {return a;}
  public double GetB()
    {return b;}
  public double GetC()
    {return c;}
  public double getDiscriminant() {
    double disc = Math.Pow(b,2) - (4*a*c);
    return disc;
  }
  public double getRoot1() {
    double root1 = (-b + (Math.Sqrt(Math.Pow(b,2) - (4*a*c))))/(2*a);
    return root1;
  }
  public double getRoot2() {
    double root2 = (-b - (Math.Sqrt(Math.Pow(b,2) - (4*a*c))))/(2*a);
    return root2;
  }
}

class MainClass {
  public static void Main() {
    double test,test2,test3;
    Console.WriteLine("What is the equation: ");
    string TestingS = Console.ReadLine(); //assume 3x^2+4x+8 styling
    test = Convert.ToDouble(Convert.ToString(TestingS[0])); //example had only single digits
    test2 = Convert.ToDouble(Convert.ToString(TestingS[5])); //so i only checked for single digits
    test3 = Convert.ToDouble(Convert.ToString(TestingS[8])); //hope that's fine
    QuadEq Testing = new QuadEq(test,test2,test3); 
    Console.WriteLine(Testing.GetA() + " " + Testing.getDiscriminant() + " " +  Testing.getRoot1() + " " +  Testing.getRoot2());
  }
}