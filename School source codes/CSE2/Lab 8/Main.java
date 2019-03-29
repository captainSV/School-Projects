import java.util.Scanner;

class Main {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    String a = "";
    String b = "";
    SVArrList numbers = new SVArrList();
    while (a != "Stop" && numbers.size() < 10){
      System.out.println("What is the number you wish to add? Type \"Stop\" to end.");
      a = scan.nextLine();
      if (a.equals("Stop")){
        break;
      }else{
        numbers.add(Integer.parseInt(a));
      }
    }
    System.out.println("The numbers are: " + numbers.list() + "\nand the sum of those numbers is: " + Counter(numbers));
    linklist LLnumbers = new linklist();
    while (b != "Stop" && LLnumbers.size() < 10){
      System.out.println("What is the number you wish to add? Type \"Stop\" to end.");
      b = scan.nextLine();
      if (b.equals("Stop")){
        break;
      }else{
        LLnumbers.add(Integer.parseInt(b));
      }
    }
    System.out.println("The numbers are: " + LLnumbers.list() + "\nand the sum of those numbers is: " + LLCounter(LLnumbers));
  }
  public static int Counter(SVArrList a){
    int sum = 0;
    for(int i = 0; i < a.size(); i++){
      sum += a.get(i);
    }
    return sum;
  }
  public static int LLCounter(linklist a){
    int sum = 0;
    for(int i = 0; i < a.size(); i++){
      sum += a.get(i);
    }
    return sum;
  }
}