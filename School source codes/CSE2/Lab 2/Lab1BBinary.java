
//Sasha Angermueller
//CSE1322 Lab Section 06
import java.util.Random;
import java.util.Arrays;
import java.io.*;
import java.util.Scanner;

class Lab1BBinary {  
  private static int binarySearch(int[] x, int key){
    int[] magic = new int[x.length];
    magic = x;
    Arrays.sort(magic);
    int low = 0;
    int high = magic.length;
    int mid = (high + low)/2;
    while(low <= high){
      mid = (high + low)/2;
      if(magic[mid] < key){
        low = mid + 1;
      }else if(magic[mid] > key){
        high = mid - 1;
      }else if(magic[mid] == key){
        return mid;
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
    int resultS = binarySearch(nums, key);
    int resultR = binarySearch(data, key);
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