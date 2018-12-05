using System;
using System.Collections.Generic;
using System.Linq;

class MainProgram {
  public static void BubbleSort(int[,] X){
    int temp = 0;
    for (int l = 0; l < 3; l++) {
      for (int i = 0; i < 3; i++) {
        for (int k = 0; k < 3-1 ; k++){
          if (X[i,k] > X[i,k + 1]){
              temp = X[i,k + 1];
              X[i,k + 1] = X[i,k];
              X[i,k] = temp;
          }
        }
      }
    }
  }
  public static bool isEquivilent(int[,] x, int[,] y){
    int count = 0;
    BubbleSort(x);
    BubbleSort(y);
    for (int k = 0;k < 3;k++) {
      for (int j = 0;j < 3;j++) {
        if (x[k,j] == y[k,j]){
          count++;
        }
      }
    }
    if (count == 9) return true;
    else return false;
  }
  public static void Main (string[] args) {
    int[,] a = new int[,] {{1,2,3},{4,5,6},{7,8,9}};
    int[,] b = new int[,] {{1,2,3},{6,5,4},{7,8,9}};
    if (isEquivilent(a,b) == true){
    Console.WriteLine("Judgement: The arrays are equivalent");
    }
    else {
      Console.WriteLine("Judgement: The arrays are not equivalent");
    }
  }
}