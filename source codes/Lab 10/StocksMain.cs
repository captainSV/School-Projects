using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main() {
    Stock test = new Stock("Yahoo", "YHOO");
    Stock test2 = new Stock("Google", "GOOG");
    test.SetClosing(130.49);
    test.SetCurrent(135.84);
    test2.SetClosing(1350.72);
    test2.SetCurrent(1402.67);
    Console.WriteLine("Yahoo Stock:\nSymbol: " + test.Ticker + "\nClosing price: " + test.prevClosingPrice + "\nCurrent price: " + test.currentPrice + "\nPercent Change: " + test.GetChangePercent() + "\n" + test);
    Console.WriteLine("\n");
    Console.WriteLine("Google Stock:\nSymbol: " + test2.Ticker + "\nClosing price: " + test2.prevClosingPrice + "\nCurrent price: " + test2.currentPrice + "\nPercent Change: " + test2.GetChangePercent() + "\n" + test2);
  }
}