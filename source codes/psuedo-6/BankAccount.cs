using System;
using System.Collections.Generic;
using System.Linq;

public class BankAccount {
  private int id {get;set;}
  private double balance {get;set;}
  private double annualInterestRate {get;set;}
  private DateTime dateCreated {get;set;}
  public BankAccount(){
    id = 0;
    balance = 0.0;
    annualInterestRate = 0.0;
  }
  public BankAccount(int idint, double bal){
    id = idint;
    balance = bal;
    annualInterestRate = 0.0;
  }
  public void SetId(int a)
    {id = a;}
  public void SetBalance(double a)
    {balance = a;}
  public void SetAnnualInterestRate(double a)
    {annualInterestRate = a/100;}

  public int GetId()
    {return id;}
  public double GetBalance()
    {return balance;}
  public double GetAnnualInterestRate()
    {return annualInterestRate;}
  public DateTime GetDateCreated()
    {return dateCreated;}

  public double GetMonthlyInterestRate() {
    return (annualInterestRate/12);
  }
  public double GetMonthlyInterest() {
    return Math.Round(balance*(annualInterestRate/12),2);
  }

  public void Withdraw(double w) {
    balance = balance - w;
  }
  public void Deposit(double w) {
    balance = balance + w;
  }
  public override string ToString() {
    return "Account ID:".PadRight(20) + id + "\nAccount Balance: ".PadRight(20) + "$" + balance + "\nInterest Rate: ".PadRight(20) + annualInterestRate + "%" + "\nDate Opened: ".PadRight(20) + dateCreated;
  }
}

class MainClass {
  public static void Main() {
    BankAccount test = new BankAccount(12345,10000);
    test.SetAnnualInterestRate(2.5);
    test.Withdraw(3500);
    test.Deposit(500);
    Console.WriteLine(test.GetBalance());
    Console.WriteLine(test.GetMonthlyInterest());
    Console.WriteLine(test.GetDateCreated());
  }
}