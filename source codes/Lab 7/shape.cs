using System;

class MainClass {
  public static void Main (string[] args) {
    int nmbroflayer = 8, Space, nmbr;  
    for (int i = 1; i <= nmbroflayer; i++) {  
    for (Space = 1; Space <= (nmbroflayer - i); Space++)  
        {Console.Write(" "); } 
    for (nmbr = 1; nmbr <= i; nmbr++) //increase the value  
        {Console.Write('*');}  
    for (nmbr = (i-1); nmbr >= 1; nmbr--) //decrease the value  
        {Console.Write('*');} 
    Console.WriteLine();
    }
  }
}