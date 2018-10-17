using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static double displaySums(int x){
    double counter = 0,sumsum = 0;
    Console.WriteLine("i" + "      " + "Sum(i)");//didn't know if you wanted this format specifically, so I did it anyway.
    while (counter <= x) {
      sumsum = sumsum + (counter/(counter+1));
      Console.WriteLine(counter + "      " + sumsum);//spacing breaks once you get into multi digit numbers, woops
      counter++;
    }
    return sumsum;
  }
  public static void Main (string[] args) {
    int zed;
    Console.WriteLine("Enter a number: ");
    zed = Convert.ToInt32(Console.ReadLine());
    displaySums(zed); //prints in method
  }
}