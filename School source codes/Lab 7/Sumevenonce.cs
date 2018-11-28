using System;

class MainClass {
  public static void Main (string[] args) {
    int sum,input,count;
    sum = 0;
    count = 2;
    Console.Write("Entered Value: ");
    input = Convert.ToInt32(Console.ReadLine());
    if (input > 20 && input < 60){
    while (count <= input) {
    sum = sum + count;
    count += 2;}
    Console.WriteLine("Sum of even numbers between 2 and " + input + " is " + sum);}
    else {
      Console.WriteLine("Yo that's actually an invalid number for this program. Please try again.");
    }
  }
}