using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main() {
    int size,count=0,counter=0,test;
    string lettergrade;
    Console.WriteLine("What is the class size: ");
    size = Convert.ToInt32(Console.ReadLine());
    int[] Class = new int[size];
    Console.WriteLine("Enter their grades: ");
    while (count < size){
      test = Convert.ToInt32(Console.ReadLine());
      if (test >= 0 && test <= 100) {
        Class[count] = test;
        count++;
      }
      else
        {Console.WriteLine("Invalid number, try again.");}
    }
  while (counter < size){
    if(Class[counter] <=100 && Class[counter] >=90) 
      {lettergrade = "A";}
    else if(Class[counter] <= 89 && Class[counter] >=80) 
      {lettergrade = "B";}
    else if(Class[counter] <= 79 && Class[counter] >=70) 
      {lettergrade = "C";}
    else if(Class[counter] <= 69 && Class[counter] >=60) 
      {lettergrade = "D";}
    else 
      {lettergrade = "F";}
    Console.WriteLine("Student " + counter + " score is " + Class[counter] + " and grade is " + lettergrade);
    counter++;
    }
  }
}