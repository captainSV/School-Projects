using System;

class MainClass {
  public static void Main (string[] args) {
    int income;
    double tax_bracket,taxdue;
    Console.WriteLine("Annual income: ");
    income = Convert.ToInt32(Console.ReadLine());
    if (income <= 50000) {
        tax_bracket = 5;
        taxdue = (income*.05);}
    else if (50000 < income && income <= 200000) {
        tax_bracket = 10;
        taxdue = ((income-50000)*.1) + 2500;}
    else if (200000 < income && income <= 400000) {
        tax_bracket = 15;
        taxdue = ((income-200000)*.15) + 15000 + 2500;}
    else if (400000 < income && income <= 900000) {
        tax_bracket = 25;
        taxdue = ((income-400000)*.25) + 30000 + 15000 + 2500;}
    else {
        tax_bracket = 35;
        taxdue = ((income-900000)*.35) + 125000 + 30000 + 15000 + 2500;}
    Console.WriteLine ("Tax Bracket: " + tax_bracket + "%");
    Console.WriteLine ("Tax due amount: $" + taxdue);
  }
}