using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int[] GetSum(int[,] y){
    int sum = 0;
    int[] x = new int[4];
    for (int k = 0;k < 4;k++) {
      for(int ime = 0;ime < 3;ime++){
        sum = sum + y[ime,k];
      }
      x[k] = sum;
      sum = 0;
    }
    return x;
  }
  public static void Main() {
    int[,] Arr1 = new int[3,4];
    int[] blegh = new int[4];
    int count = 0, counter = 0, test;
    Console.WriteLine("What are the array values: ");
    //Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);
    while (count < 3){ 
      test = Convert.ToInt32(Console.ReadLine());
      Arr1[count,counter] = test;
      counter++;
      if (counter == 4) {
        counter = 0; count++;
      }
    }
    Console.Write("Original Array: ".PadRight(20)+"\n");
    for (int k = 0;k < 3;k++) {
      for(int i = 0; i < 4;i++){
        Console.Write(Arr1[k,i] + ",");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
    blegh = GetSum(Arr1);
    for (int k = 0;k < 4;k++) {
      Console.WriteLine("Sum of column " + k + " is " + blegh[k]);
    }
  }
}
