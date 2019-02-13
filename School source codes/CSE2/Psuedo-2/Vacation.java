public class Vacation{

  public int budget;
  public String destination;

  public Vacation(int budget, String destination){
    this.budget = budget;
    this.destination = destination;
  }
  public String budgeting(int price){
    if (budget == price){
      return "On budget";
    }else if (budget > price){
      return "Price is " + (budget-price) + " under budget.";
    }else{
      return "Price is " + (price-budget) + "  over budget.";
    }
  }
  public int getBudget(){
    return budget;
  }
  public void setBudget(int a){
    budget = a;
  }
  public String getDest(){
    return destination;
  }
  public void setDest(String a){
    destination = a;
  }
}