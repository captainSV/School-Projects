using System;

class Coins {
  public static void Main (string[] args) {
    int NQuarters, NDimes, NNickles, NPennies, Dollars, Cents;
    Console.WriteLine ("Enter Number of Quarters: ");
    NQuarters = int.Parse(Console.ReadLine());
    Console.WriteLine ("Enter Number of Dimes: ");
    NDimes = int.Parse(Console.ReadLine());
    Console.WriteLine ("Enter Number of Nickles: ");
    NNickles = int.Parse(Console.ReadLine());
    Console.WriteLine ("Enter Number of Pennies: ");
    NPennies = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine ("You entered " + NQuarters + " Quarters");
    Console.WriteLine ("You entered " + NDimes + " Dimes");
    Console.WriteLine ("You entered " + NNickles + " Nickles");
    Console.WriteLine ("You entered " + NPennies + " Pennies");
    Console.WriteLine();
    NQuarters = NQuarters * 25;
    NDimes = NDimes * 10;
    NNickles = NNickles * 5;
    NPennies = NPennies * 1;
    Dollars = (NQuarters + NDimes + NNickles + NPennies)/100;
    Cents = (NQuarters + NDimes + NNickles + NPennies)%100;
    Console.WriteLine ("Your total is " + Dollars + " Dollars and " + Cents + " Cents.");
    Console.ReadLine();
  }
}