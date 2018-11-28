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