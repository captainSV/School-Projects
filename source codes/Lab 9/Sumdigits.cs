using System;

class MainClass {
  public static int SumDigits(int x) {
    int sum = 0,m;
    while(x>0){      
      m=x%10;      
      sum=sum+m;      
      x=x/10;}
    return sum;
  }
  public static void Main (string[] args) {
    int number;
    Console.Write("What is the number: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Sum of digits is " + SumDigits(number));
  }
}