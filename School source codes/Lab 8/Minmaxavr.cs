using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static double Max (double x,double y,double z) {
    double[] k = {x,y,z};
    double kmax = k.Max();
    return kmax;
  }
  public static double Min (double x,double y,double z) {
    double[] k = {x,y,z};
    double kmin = k.Min();
    return kmin;
  }
  public static double Avr (double x,double y,double z) {
    double k = Convert.ToDouble((x+y+z)/3);
    return k;
  }
  public static void Main (string[] args) {
    double zed,zedd,zeddd,zedmax,zedmin,zedavr;
    Console.Write("enter your numbers: ");
    zed = Convert.ToDouble(Console.ReadLine());
    zedd = Convert.ToDouble(Console.ReadLine());
    zeddd = Convert.ToDouble(Console.ReadLine());
    zedmax = Max(zed,zedd,zeddd);
    zedmin = Min(zed,zedd,zeddd);
    zedavr = Avr(zed,zedd,zeddd);
    Console.WriteLine("You Entered: " + zed + ", " + zedd + ", " + zeddd);
    Console.WriteLine("Max valuee " + zedmax);
    Console.WriteLine("Min value: " + zedmin);
    Console.WriteLine("Average Value: " + zedavr);
  }
}