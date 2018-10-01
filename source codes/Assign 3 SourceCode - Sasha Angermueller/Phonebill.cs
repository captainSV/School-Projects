using System;

class MainClass {
  public static void Main (string[] args) {
    int AccountNum,minutes,daytime,nighttime;
    double charge,overcharge,daycharge,nightcharge;
    string Service;
    Console.WriteLine("Account number?");
    AccountNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Service type?");
    Service = Console.ReadLine();
    if (Service == "Regular") {
        Console.WriteLine("Total minutes used?");
        minutes = Convert.ToInt32(Console.ReadLine());
        if (minutes > 50) {
            charge = 15.00;
            overcharge = (minutes%50)*.5;
            Console.WriteLine("Amount due: " + (charge+overcharge));}
        else {
            charge = 15.00;
            Console.WriteLine("Amount due: " + (charge));}}
    else {
        Console.WriteLine("Daytime Minutes?");
        daytime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nighttime minutes?");
        nighttime = Convert.ToInt32(Console.ReadLine());
        if (daytime > 50)
            {daycharge = (daytime-50)*.2;}
        else
            {daycharge = 0;}
        if (nighttime > 100)
            {nightcharge = (nighttime-100)*.1;}
        else
            {nightcharge = 0;}
        Console.WriteLine("Amount due: " + (nightcharge+daycharge+25.00));}
  }
}