using System;
using System.Collections.Generic;
using System.Linq;

public class Stock {
  public Stock(string name, string ticker) {
    Name = name;
    Ticker = ticker;
    prevClosingPrice = 1;
    currentPrice = 1;
  }
  public string Name {get;set;}
  public string Ticker {get;set;}
  public double prevClosingPrice {get;set;}
  public double currentPrice {get;set;}
  public double percentChange {get;set;}
  public string GetName() {
    return Name;
  }
  public string GetSymbol() {
    return Ticker;
  }
  public string GetChangePercent() {
    percentChange = ((prevClosingPrice - currentPrice)/prevClosingPrice) * 100;
    return Math.Round(percentChange) + "%";
  }
  public void SetClosing (double tripe){
    prevClosingPrice = tripe;
  }
  public void SetCurrent (double tripe){
    currentPrice = tripe;
  }
  public override string ToString(){
      return Name + " stock's closing price is " + prevClosingPrice;
  }
}

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