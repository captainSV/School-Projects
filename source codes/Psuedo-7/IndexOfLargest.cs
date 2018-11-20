using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int Count(int[] x) {
    int meh = 0, blegh = x[0];
    for (int k = 0;k < x.Length;k++){
      if (x[k] > blegh){
        meh = k;
        blegh = x[k];
      }
    }
    return meh;
  }
  public static void Main() {
    int[] Arr1 = new int[10];
    int count=0,test;
    Console.WriteLine("Enter the numbers for the array: ");
    while (count < 10){
      test = Convert.ToInt32(Console.ReadLine());
      Arr1[count] = test;
      count++;
    }
    Console.Write("Original Array: ".PadRight(20) + Arr1[0]);
    for (int k = 1;k < Arr1.Length;k++)
      {Console.Write(", " + Arr1[k]);}
    Console.WriteLine();
    Console.WriteLine("Index of Largest number is: " + Count(Arr1));
  }
}