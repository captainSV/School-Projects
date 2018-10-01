using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    string[] currentday = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
    int currentdate,daystil,date;
    Console.WriteLine ("Enter the value representing the date: ");
    currentdate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("How many days untill your meeting? ");
    daystil = Convert.ToInt32(Console.ReadLine());
    date = (currentdate+daystil)%7;
    Console.WriteLine("Today is " + currentday[currentdate%7]);
    Console.WriteLine("Days until meeting is " + daystil + " days");
    Console.WriteLine("meeting day is " + currentday[date]);
  }
}