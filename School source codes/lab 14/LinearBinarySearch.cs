using System;
using System.Collections.Generic;
using System.Linq;

class MainProgram {
  public static int LinearSearch(int[] x, int y){
      for(int i = 0; i < x.Length; i++) {
        if(x[i] == y) return i+1;
      }
      return -1;
    }
    public static object BinarySearch(int[] inputArray, int key){ 
    int min = 0,count=0;
    int max = inputArray.Length - 1; 
    while (min <=max){  
      int mid = (min + max) / 2;  
      if (key == inputArray[mid]){  
        return count;  
      }  
      else if (key < inputArray[mid]){  
        max = mid - 1;  
      }  
      else{
        min = mid + 1;  
      }
      count++; 
    }  
    return "Nil";  
  }
  public static void Main (string[] args) {
    int count=0,value,testval;
    int[] arr = new int[10];
    Console.WriteLine("Enter the numbers for the array: ");
    while (count < 10){
      value = Convert.ToInt32(Console.ReadLine());
      arr[count] = value;
      count++;
    }
    Console.Write("Array elements: ");
    for (int k = 0;k < 10;k++) {
        Console.Write(arr[k] + ", ");
      }
    Console.Write("\nWhat is the value to search for: ");
    testval = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nLinear Search Comparisons: " + LinearSearch(arr, testval));
    Console.WriteLine("Binary Search Comparisons: " + BinarySearch(arr, testval));
  }
}