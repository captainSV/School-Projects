using System;

class MainClass {
  public static void Main (string[] args) {
    double EX1,EX2,EY1,EY2,RAD1,RAD2,RADSUM,DISTANCE;
    Console.WriteLine("first circle Center X: ");
    EX1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("first circle Center Y: ");
    EY1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("first circle Radius: ");
    RAD1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("second circle Center X: ");
    EX2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("second circle Center Y: ");
    EY2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("second circle Radius ");
    RAD2 = Convert.ToDouble(Console.ReadLine());
    DISTANCE = Math.Sqrt( ((EX2-EX1)*(EX2-EX1)) + ((EY2-EY1)*(EY2-EY1)) );
    RADSUM = Math.Sqrt((RAD1 + RAD2)*(RAD1 + RAD2));
    if (RAD1 > (DISTANCE + RAD2))
        {Console.WriteLine("Circle 2 is compleatly inside circle 1");}
    else if (DISTANCE < RADSUM)
        {Console.WriteLine("Circle 2 is overlapping with circle 1");}
    else
        {Console.WriteLine("Circle 2 is compeatly outside circle 1");}
  }
}