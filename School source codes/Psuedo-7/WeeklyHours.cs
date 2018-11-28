using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void MinMaxAvg(int[,] x) {
    Console.WriteLine("Employee# ".PadRight(20) + "Weekly Hours");
    int emplyhours = 0;
    for (int k = 0;k < 3;k++) {
      Console.Write((k+1) + "".PadRight(20));
      for(int i = 0; i < 7;i++){
        emplyhours = emplyhours + x[k,i];
      }
      Console.Write(emplyhours + "\n");
      emplyhours = 0;
    }
  }
  public static void Main() {
    int[,] Arr1 = new int[3,7];
    int count = 0, counter = 0, test;
    Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);;
    while (count < 3){ 
      test = rnd.Next(0, 10);
      Arr1[count,counter] = test;
      counter++;
      if (counter == 6) {
        counter = 0; count++;
      }
    }
    Console.Write("Employee's and hours per day: \n");
    for (int k = 0;k < 3;k++) {
      Console.Write("Employee "+ (k+1) + "".PadRight(5));
      for(int i = 0; i < 7;i++){
        Console.Write(Arr1[k,i] + ", ");
      }
      Console.Write("\n");
    }
    Console.WriteLine();
    MinMaxAvg(Arr1);
  }
}