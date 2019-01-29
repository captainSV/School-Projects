
//Sasha Angermueller
//CSE1322 Lab Section 06
import java.util.Random;
import java.util.Arrays;
import java.io.*;
import java.util.Scanner;

class Lab1BLinear {  
  private static int linearSearch(int[] x, int key){    
    for(int i = 0;i < x.length ; i++){
      if(x[i] == key){
        return i;
      }
    }
    return -1;
  }
  private static int[] fillArray(int[] num) {
    Random rand = new Random();
    for (int counter = 0; counter < 20; counter++){
      num[counter] = rand.nextInt(100 + 1 + 100) - 100;
    }
    return num;
  }
  public static void main(String[] args) {
    int[] nums = new int[]{1, 4, 4, 22, -5, 10, 21, -47, 23};
    int key;
    int[] data = new int[20];
    Scanner scan = new Scanner(System.in);
    data = fillArray(data);
    System.out.println("What is the number to search for?");
    key = Integer.parseInt(scan.nextLine());
    int resultS = linearSearch(nums, key);
    int resultR = linearSearch(data, key);
    if (resultR != -1 && resultS != -1){
      System.out.println("The value " + key + " was found in both static and random arrays, at indexs " + resultS + " and " + resultR + " respectfully.");
    }else if (resultR == -1 && resultS != -1){
      System.out.println("The value " + key + " was found in only the static array, at index " + resultS + ".");
    }else if (resultR != -1 && resultS == -1){
      System.out.println("The value " + key + " was not found in the static array, but was found in the random one, at index " + resultR + ".");
    }else{
      System.out.println("The value " + key + " was not found in either array, sorry.");
    }
  }
}