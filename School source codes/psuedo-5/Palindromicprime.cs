using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static int Palindrome(int x){
    int rem,reverse;
    reverse = 0;
    while(x!=0) {      
      rem = x%10;        
      reverse = (reverse * 10) + rem;      
      x/=10;}
    return reverse;
  }
  public static bool isPrime(int num) {
    if (num == Palindrome(num)) {
    int k;
    k = 0;
    for (int i = 1; i <= num; i++) {
      if (num % i == 0) 
        {k++;}
    }
    if (k == 2) return true;
    else return false;
    }
    return false;
}
  public static void Main (string[] args) {
    int counter = 0,counter2 = 1,counter3 = 0;
    while (counter3 < 50) {
      if (isPrime(counter) == true)
        {Console.Write(counter + " ");counter2++;counter3++;}
      if(counter2%11 == 0)
        {Console.WriteLine();counter2++;}
      counter++;
    }
  }
}