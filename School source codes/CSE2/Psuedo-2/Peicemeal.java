public class Peicemeal extends Vacation{

  public String items;
  public int costs;

  public Peicemeal(int budget, String destination, String items,int costs){
    super(budget,destination);
    this.items = items;
    this.costs = costs;
  }
  public String budgeting(){
    if (budget == costs){
      return "On budget";
    }else if (budget > costs){
      return "Price is " + (budget-costs) + " under budget.";
    }else{
      return "Price is " + (costs-budget) + "  over budget.";
    }
  }
  public String getItems(){
    return items;
  }
  public int getCosts(){
    return costs;
  }
  public void setItemsAndCosts(String a, int b){
    items = a;
    costs = b;
  }
}