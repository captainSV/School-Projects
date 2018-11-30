using System;
using System.Collections.Generic;
using System.Linq;

class MainProgram {
  public static int BubbleSort(int[] X){
    int temp = 0,counter = 0;
    for (int i = 0; i < X.Length; i++) {
      for (int k = 0; k < X.Length - 1; k++){
        if (X[k] > X[k + 1]){
            temp = X[k + 1];
            X[k + 1] = X[k];
            X[k] = temp;
            counter++;
        }
      }
    }
    return counter;
  }
  public static int InsertionSort(int[] y){
    int steps = 0;
    for (int i = 0; i < y.Length-1; i++){
      int k = i + 1;
      while(k > 0 && (y[k] < y[k - 1])){
        int temp = y[k-1];
        y[k - 1] = y[k];
        y[k] = temp;
        k--;
        steps++;
      }
    }
    return steps;
  }
  public static int SelectionSort(int[] z){
    int selections = 0;
    for(int q=0; q < z.Length; q++){
      int mindex = q;
      for(int w = q; w < z.Length; w++){
        if(z[mindex] > z[w]){
          mindex = w;
        }
        int temp = z[q];
        z[q] = z[mindex];
        z[mindex] = temp;
        selections++;
      }
    }
    return selections;
  }
  public static void Main (string[] args) {
    int count=0,value;
    Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246);
    int[] arrbb = new int[50];
    int[] arri = new int[50];
    int[] arrs = new int[50];
    while (count < 50){
      value = rnd.Next(0,100);
      arrbb[count] = value;
      arri[count] = value;
      arrs[count] = value;
      count++;
    }
    Console.Write("Array elements: ");
    for (int k = 0;k < 50;k++) {
      Console.Write(arrbb[k] + ", ");
    }
    int bbcount = BubbleSort(arrbb);
    Console.Write("\n\nBubble elements: ");
    for (int k = 0;k < 50;k++) {
      Console.Write(arrbb[k] + ", ");
    }
    Console.WriteLine("\nBubble interations: " + bbcount);
    int icount = InsertionSort(arri);
    Console.Write("\n\nInsertion elements: ");
    for (int k = 0;k < 50;k++) {
      Console.Write(arri[k] + ", ");
    }
    Console.WriteLine("\nInsertion interations: " + icount);
    int scount = SelectionSort(arrs);
    Console.Write("\n\nInsertion elements: ");
    for (int k = 0;k < 50;k++) {
      Console.Write(arrs[k] + ", ");
    }
    Console.WriteLine("\nSelection interations: " + scount);
  }
}