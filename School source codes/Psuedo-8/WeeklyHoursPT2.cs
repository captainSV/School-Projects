using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void BubbleSort(int[] X){
    int temp = 0;
    for (int i = 0; i < X.Length; i++) {
      for (int k = 0; k < X.Length - 1; k++){
        if (X[k] > X[k + 1]){
            temp = X[k + 1];
            X[k + 1] = X[k];
            X[k] = temp;
        }
      }
    }
  }
  public static void MinMaxAvg(int[,] x) {
    Console.WriteLine("Employee# ".PadRight(20) + "Weekly Hours");
    int emplyhours = 0;
    int[] emphrs = new int[3];
    int[] emphrsnsrt = new int[3];
    for (int k = 0;k < 3;k++) {
      for(int i = 0; i < 7;i++){
        emplyhours = emplyhours + x[k,i];
      }
      emphrs[k] = emplyhours;
      emphrsnsrt[k] = emplyhours;
      emplyhours = 0;
    }
    BubbleSort(emphrs);
    Console.WriteLine("Employee " + (Array.IndexOf(emphrsnsrt, emphrs[0]) + 1) + "".PadRight(20) + emphrs[0]);
    Console.WriteLine("Employee " + (Array.IndexOf(emphrsnsrt, emphrs[1]) + 1) + "".PadRight(20) + emphrs[1]);
    Console.WriteLine("Employee " + (Array.IndexOf(emphrsnsrt, emphrs[2]) + 1) + "".PadRight(20) + emphrs[2]);
  }
  public static void Main() {
    int[,] Arr1 = new int[3,7];
    int[] em1hours = new int[7];
    int[] em2hours = new int[7];
    int[] em3hours = new int[7];
    string[] days = new string[] {"Monday","Tuesday","Wednesday","Thursday","Friday","SaterDay","Sunday"};
    int test = 0,em1max = 0,em2max = 0,em3max = 0;
    Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);
    for (int count = 0; count < 3;count++){
      for (int counter = 0; counter < 7;counter++){
        test = rnd.Next(0, 10);
        Arr1[count,counter] = test;
      }
    }
    Console.WriteLine("Employees and hours per day: \n");
    for (int k = 0;k < 3;k++) {
      Console.Write("Employee "+ (k+1) + "".PadRight(5));
      for(int i = 0; i < 7;i++){
        Console.Write(Arr1[k,i] + ", ");
      }
      Console.Write("\n");
    }
        Console.WriteLine();
    for(int i = 0; i < 7;i++){
      em1hours[i] = Arr1[0,i];
    }
    for(int i = 0; i < 7;i++){
      em2hours[i] = Arr1[1,i];
    }
    for(int i = 0; i < 7;i++){
      em3hours[i] = Arr1[2,i];
    }
    em1max = Array.IndexOf(em1hours, em1hours.Max());
    em2max = Array.IndexOf(em2hours, em2hours.Max());
    em3max = Array.IndexOf(em3hours, em3hours.Max());
    Console.WriteLine("Employee 1 worked the most on " + days[em1max]);
    Console.WriteLine("Employee 2 worked the most on " + days[em2max]);
    Console.WriteLine("Employee 3 worked the most on " + days[em3max]);
    Console.WriteLine();
    MinMaxAvg(Arr1);
  }
}