using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void MinMaxAvg(int[,] x) {
    int max, min;
    double avg = 0;
    max = x.Cast<int>().Max();
    min = x.Cast<int>().Min();
    for (int k = 0;k < 4;k++) {
      for(int i = 0; i < 4;i++){
        avg = avg + x[k,i];
      }
    }
    avg = avg/16;
    Console.WriteLine("Highest Grade: " + max + "\nLowest Grade: " + min + "\nClass Average: " + avg);
  }
  public static void Main() {
    int[,] Arr1 = new int[4,4];
    int count = 0, counter = 0, test;
    Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);;
    while (count < 4){ 
      test = rnd.Next(0, 100);
      Arr1[count,counter] = test;
      counter++;
      if (counter == 3) {
        counter = 0; count++;
      }
    }
    Console.Write("Class Grade Array: \n");
    for (int k = 0;k < 4;k++) {
      for(int i = 0; i < 4;i++){
        Console.Write(Arr1[k,i] + ",");
      }
      Console.Write("\n");
    }
    Console.WriteLine();
    MinMaxAvg(Arr1);
  }
}