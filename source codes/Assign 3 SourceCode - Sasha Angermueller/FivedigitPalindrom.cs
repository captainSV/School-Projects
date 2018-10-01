using System;

class MainClass {
  public static void Main (string[] args) {
    int plindrome,temp,rev,accumulator;
    Console.WriteLine("Enter number: ");
    plindrome = Convert.ToInt32(Console.ReadLine());
    if (99999 > plindrome && plindrome > 11111) {
      temp = plindrome;
      rev = 0; //for holding reverse value for checking
      while(plindrome > 0) {//counter statement, basically
          accumulator = plindrome%10; //getting the last place value
          rev = (rev * 10)+accumulator; //multiplying the reverse number by ten to shift it one place forward, and then adding the last place of the input.                                       //Basically, reverseing the number
          plindrome = plindrome/10;} //chopping off the last place of the input, for use in the loop
      if(temp == rev)
          {Console.WriteLine("The number is a palindrome!");}
      else
          {Console.WriteLine("The number isn't a palindrome!");}}
    else
      {Console.WriteLine("Invalid 5-digit number. Try again.");}
  }
}