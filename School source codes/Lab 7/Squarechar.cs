using System;

class MainClass {
  public static void Main (string[] args) {
    char input;
    int size,counter,longsize;
    longsize = 1;
    Console.Write("What's the character? ");
    input = Convert.ToChar(Console.ReadLine());
    Console.Write("What's the size? ");
    size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    while (longsize <= size) {
    for (counter = 1; counter <= size; counter++)
      {Console.Write(input);}
    Console.WriteLine();
    longsize++;
    }
  }
}