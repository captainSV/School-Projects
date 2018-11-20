using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static bool Compare(int[] x, int[] y){
    if (x.SequenceEqual(y)) return true;
    else return false;
  }
  public static void Main() {
    int size,count1=0,count2=0,test;
    Console.WriteLine("What is the array size: ");
    size = Convert.ToInt32(Console.ReadLine());
    int[] Arr1 = new int[size];
    int[] Arr2 = new int[size];
    Console.WriteLine("Enter the numbers for array 1: ");
    while (count1 < size){
      test = Convert.ToInt32(Console.ReadLine());
      Arr1[count1] = test;
      count1++;
    }
    Console.WriteLine("Enter the numbers for array 2: ");
    while (count2 < size){
      test = Convert.ToInt32(Console.ReadLine());
      Arr2[count2] = test;
      count2++;
    }
    if (Compare(Arr1,Arr2) == false)
      {Console.WriteLine("The arrays are not identical.");}
    else
      {Console.WriteLine("The arrays are identical.");}
  }
}