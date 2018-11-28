using System;

static class MainClass {
  public static string printChars(this string value, string a, string b) {
    int posA = value.IndexOf(a);
    int posB = value.LastIndexOf(b);
    if (posA == -1) //these if statements return an empty string if the chars aren't
      {return "";}  //in the correct order.
    if (posB == -1)
      {return "";}
    int adjustedPosA = posA + a.Length - 1; //the -1 is to make it inclusive
    if (adjustedPosA >= posB)
      {return "";}
    return value.Substring(adjustedPosA, posB - adjustedPosA + 1); //+1 inclusiveness
    }
  public static void Main (string[] args) {
    string test = "0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz"; //set up the string, which is by it's nature a char array. This string was generated with a different program and then hard coded in here//
    Console.WriteLine("What is the start Character: ");
    string start = Console.ReadLine();
    Console.WriteLine("What is the end Character: ");
    string end = Console.ReadLine();
    string testing = test.printChars(start, end);
    int count = 0;
    if (testing == "") //if printchars returns 'false', print error string
      {Console.WriteLine("start and end characters are out of order. Try again.");}
    while (count < testing.Length) {
      if (count%5 == 0)
        {Console.WriteLine();} //makes the newline at 5 characters
      Console.Write(testing[count]);
      count++;
    }
  }
}