class Main {
  public static void main(String[] args){
    Vacation dad =  new Vacation(10,"atlanta");
    AllInclusive cad = new AllInclusive(10,"atlanta","Holiday Inn",4, 12);
    Peicemeal bad = new Peicemeal(10,"atlanta","hotel, meal, Gas", 10);
    System.out.println("Base testing:");
    System.out.println(dad.budgeting(15));
    dad.setBudget(15);
    System.out.println(dad.getBudget());
    System.out.println(dad.budgeting(15));
    System.out.println("AllInclusive testing:");
    System.out.println (cad.budgeting());
    System.out.println (cad.getBrand());
    System.out.println (cad.getRating());
    System.out.println ("Peicemeal testing:");
    System.out.println (bad.budgeting());
    System.out.println (bad.getItems());
    bad.setItemsAndCosts("hotel, meal, Gas, Concert", 14);
    System.out.println (bad.budgeting());
  }
}