class AllInclusive extends Vacation{

  public String brand;
  public int rating;
  public int price;

  public AllInclusive(int budget, String destination, String brand, int rating, int price){
    super(budget,destination);
    this.brand = brand;
    this.rating = rating;
    this.price = price;
  }
  public String budgeting(){
    if (budget == price){
      return "On budget";
    }else if (budget > price){
      return "Price is " + (budget-price) + " under budget.";
    }else{
      return "Price is " + (price-budget) + "  over budget.";
    }
  }
  public String getBrand(){
    return brand;
  }
  public void setBrand(String a){
    brand = a;
  }
  public int getRating(){
    return rating;
  }
  public void setRating(int a){
    rating = a;
  }
  public int getPrice(){
    return price;
  }
  public void setPrice(int a){
    price = a;
  }
}