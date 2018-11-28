using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int Reverse (int x) {
    int k , reverse = 0, rem;
    while(x!=0) {      
        rem = x%10;        
        reverse = (reverse * 10) + rem;      
        x/=10;}
    k = reverse;
    return k;
  }
  public static int IsPalindrome (int x) {
    int k;
    if (x == Reverse(x))
      {k = 1;}
    else
      {k = 0;}
    return k;
  }
  public static void Main (string[] args) {
    Console.Write("Please enter an integer: ");
    int zed = Convert.ToInt32(Console.ReadLine());
    int zedcheck = IsPalindrome(zed);
    if (zedcheck == 1)
      {Console.WriteLine("That is a palindrome! Good job.");}
    else
      {Console.WriteLine("That is not a palindrome! Try again.");}
  }
}