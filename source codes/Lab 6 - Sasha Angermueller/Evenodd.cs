using System;

class MainClass {
  public static void Main (string[] args) {
    int count = 50;
    Console.Write("Even numbers between 50 and 100: ");
    while(count < 101) {
      if (count%2 == 0)
        {Console.Write(count+", ");}
      count += 1;
    }
    Console.WriteLine();
    count = 50;
    Console.Write("Odd numbers between 50 and 100: ");
    while(count < 100) {
      if (count%2 == 1)
        {Console.Write(count+", ");}
      count += 1;
    }
  }
}