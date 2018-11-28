using System;

class MainClass {
  public static int RandGen(){
    Random rand = new Random();
    int number = rand.Next(1,20);
    return number;
  }
  public static int FrstGuess() {
    Console.Write("What is the number: ");
    int nnumber = Convert.ToInt32(Console.ReadLine());
    return nnumber;
  }
  public static bool Wrong(int x, int y) {
    if (x != y) {
      Console.WriteLine("That's not the correct number, guess again");
      return false;
    }
    return true;
  }
  public static void Main (string[] args) {
    int number = RandGen(),nnumber = FrstGuess(),sent = 1;
    while (sent != 2) {
      while (Wrong(number,nnumber) == false) 
        {nnumber = Convert.ToInt32(Console.ReadLine());}
      Console.WriteLine("You guessed correctly!\nWould you like to quit? (Enter 2 to quit)");
      sent = Convert.ToInt32(Console.ReadLine());
      if (sent == 2) break;
      number = RandGen();
      nnumber = FrstGuess();
    }
  }
}