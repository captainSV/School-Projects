using System;

class MainClass {
  public static void Main (string[] args) {
    int countingnum;
    int x = 1;
    Console.Write("You entered: ");
    countingnum = int.Parse(Console.ReadLine());
    int sum = 0;
    if (countingnum < 0 || countingnum > 100)
      {Console.WriteLine("Invalid input. Try again.");}
    else {
    while (x <= countingnum) 
      {sum += x;x++;}
    Console.WriteLine("Sum of values: " + sum);}
  }
}