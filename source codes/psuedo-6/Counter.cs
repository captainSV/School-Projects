using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Counter {
  public Counter() {
    count = 0;
  }
  private int count {get;set;}
  public void Increment()
    {count++;}
  public int GetValue()
    {return count;}
}

class MainClass {
  public static void Main() {
    Random rnd = new Random(Guid.NewGuid().GetHashCode()/13246); 
    /*Random takes a seed, based on system time
    Because of this, and the speed of a while look, I decided to input my own sudo-random seed, which is what the GUID is I then 
    divided it by a human typed number for that extra randomness*/
    int plusser = 0;
    Counter Heads = new Counter();
    Counter tails = new Counter();
    while (plusser < 100){
      if(rnd.Next(0,2) == 0){
        Heads.Increment();
      }
      else {
        tails.Increment();
      }
      plusser++;
    }
    if(Heads.GetValue() > tails.GetValue())
      {Console.WriteLine("More Heads than Tails");}
    else if (Heads.GetValue() < tails.GetValue())
      {Console.WriteLine("More Tails than Heads");}
    else
      {Console.WriteLine("It's a Tie!");}
  }
}