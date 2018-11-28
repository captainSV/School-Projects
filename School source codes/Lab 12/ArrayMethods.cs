using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int ArrayMax(int[] x){
    return x.Max();
  }
  public static int ArrayMin(int[] x){
    return x.Min();
  }
  public static void ArraySquared(int[] x){
    for (int j = 0;j < x.Length;j++) {
      x[j] = x[j]*x[j];
      Console.Write((x[j])+ ", ");
    }
  }
  public static void ArrayReverse(int[] y){
    Array.Reverse(y);
    for (int j = 0;j < y.Length;j++)
      {Console.Write(y[j]+ ", ");}
  }
  public static void Main() {
    int size,count=0,test;
    Console.WriteLine("What is the array size: ");
    size = Convert.ToInt32(Console.ReadLine());
    int[] Arr1 = new int[size];
    Console.WriteLine("Enter the numbers for the array: ");
    while (count < size){
      test = Convert.ToInt32(Console.ReadLine());
      Arr1[count] = test;
      count++;
    }
    Console.Write("Original Array: ".PadRight(20));
    for (int k = 0;k < Arr1.Length;k++)
      {Console.Write(Arr1[k] + ", ");}
    Console.WriteLine();
    Console.WriteLine("Array Miximum: ".PadRight(20) + ArrayMax(Arr1));
    Console.WriteLine("Array Minimum: ".PadRight(20) + ArrayMin(Arr1));
    Console.Write("Array Squared: ".PadRight(20));
    ArraySquared(Arr1);
    Console.WriteLine();
    Console.Write("Array Reversed: ".PadRight(20));
    ArrayReverse(Arr1);
  }
}