using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int[] LocateLargest(int[,] y){
    int largestX = 0,largestY = 0,largest = y[0,0];
    int[] x = new int[2];
    for (int k = 0;k < 3;k++) {
      for(int ime = 0;ime < 4;ime++){
        if(y[k,ime] > largest){
          largestX = k;
          largestY = ime;
          largest = y[k,ime];
        }
      }
    }
    x[0] = largestX;
    x[1] = largestY;
    return x;
  }
  public static void Main() {
    int[,] Arr1 = new int[3,4];
    int[] blegh = new int[2];
    int count = 0, counter = 0, test;
    Console.WriteLine("What are the arrey array values: ");
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
    blegh = LocateLargest(Arr1);
    Console.Write("First largest value is located at row " + blegh[0] + " and at column " + blegh[1]);
  }
}
