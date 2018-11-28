using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main() {
    Radio test = new Radio();
    test.turnOn();
    Console.WriteLine(test);
    test.VolumeUp(3);
    Console.WriteLine(test);
    test.StationUp(5)
    Console.WriteLine(test);
    test.VolumeDown();
    Console.WriteLine(test);
    test.StationUp(3);
    Console.WriteLine(test);
    test.turnOff();
    Console.WriteLine(test);
    test.VolumeUp(2);
    Console.WriteLine(test);
    test.StationDown(2);
    Console.WriteLine(test);
  }
}