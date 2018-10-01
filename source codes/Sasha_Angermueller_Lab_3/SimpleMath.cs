using System;

class SimpleMath {
  public static void Main (string[] args) {
    float RValue, TValue;
    Console.WriteLine ("What is the R value?");
    RValue = float.Parse(Console.ReadLine());
    Console.WriteLine ("What is the T value?");
    TValue = float.Parse(Console.ReadLine());
    Console.WriteLine ("R = " + RValue);
    Console.WriteLine ("T = " + TValue);
    Console.WriteLine ("R + T = " + (TValue + RValue));
    Console.WriteLine ("R - T = " + (TValue - RValue));
    Console.WriteLine ("R * T = " + (TValue * RValue));
    Console.ReadLine();
  }
}