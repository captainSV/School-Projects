using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Entered string: ");
    string letter = Console.ReadLine();
    for (int i = 0; i < letter.Length; i++) {
      Console.Write("Letter: ");
      Console.WriteLine(letter[i]); }
    Console.ReadLine();
  }
}