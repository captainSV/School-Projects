using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.Write("Entered Value: ");
    int input = Convert.ToInt32(Console.ReadLine());
    while (input >= 20 && input <= 60)
    {
      int sum = 0;
      int count = 2;
      while (count <= input) 
      {
        sum = sum + count;
        count += 2;
      }
      Console.WriteLine("Sum of even numbers between 2 and " + input + " is " + sum);
      
      Console.Write("Entered Value: ");
      input = Convert.ToInt32(Console.ReadLine());
    }
      Console.WriteLine("Yo that's actually an invalid number for this program. Please try again.");
  }
}