using System;

class MainClass {
  public static void Main (string[] args) {
    double smallweight,smallprice,largeweight,largeprice,smalldeal,largedeal;    
    Console.WriteLine("Small box weight in pounds?");
    smallweight = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Small box price in dollars?");
    smallprice = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Large box weight in pounds?");
    largeweight = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Large box price in dollars?");
    largeprice = Convert.ToDouble(Console.ReadLine());
    smalldeal = (smallprice/smallweight);
    largedeal = (largeprice/largeweight);
    if (largedeal == smalldeal)
        {Console.WriteLine("Both boxes are the same value");}
    else if (largedeal < smalldeal)
        {Console.WriteLine("The large box is a better deal");}
    else
        {Console.WriteLine("The small box is a better deal");}
  }
}