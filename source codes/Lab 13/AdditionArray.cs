using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int[,] Addition(int[,] y,int[,] x){
    int[,] p = new int[3,3];
    for (int k = 0;k < 3;k++) {
      for(int i = 0;i < 3;i++){
        p[k,i] = y[k,i] + x[k,i];
      }
    }
    return p;
  }
  public static void Main() {
    int[,] Arr1 = new int[3,3];
    int[,] Arr2 = new int[3,3];
    int[,] Arr3 = new int[3,3];
    int count = 0, counter = 0, test;
    Console.WriteLine("What are the arrey array values: ");
    //Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);
    while (count < 3){ 
      test = Convert.ToInt32(Console.ReadLine());
      Arr1[count,counter] = test;
      counter++;
      if (counter == 3) {
        counter = 0; count++;
      }
    }
    count = 0;
    counter = 0;
    Console.WriteLine("what is the values for array 2: ");
    while (count < 3){ 
      test = Convert.ToInt32(Console.ReadLine());
      Arr2[count,counter] = test;
      counter++;
      if (counter == 3) {
        counter = 0; count++;
      }
    }
    Console.Write("Array1: ".PadRight(20)+"\n");
    for (int k = 0;k < 3;k++) {
      for(int i = 0; i < 3;i++){
        Console.Write(Arr1[k,i] + ",");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
    Console.Write("Array2: ".PadRight(20)+"\n");
    for (int k = 0;k < 3;k++) {
      for(int i = 0; i < 3;i++){
        Console.Write(Arr2[k,i] + ",");
      }
      Console.WriteLine();
    }
    Arr3 = Addition(Arr1,Arr2);
    Console.WriteLine();
    Console.Write("Array3: ".PadRight(20)+"\n");
    for (int k = 0;k < 3;k++) {
      for(int i = 0; i < 3;i++){
        Console.Write(Arr3[k,i] + ",");
      }
      Console.WriteLine();
    }
  }
}
