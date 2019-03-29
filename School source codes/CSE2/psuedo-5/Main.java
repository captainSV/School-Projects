class Main { 
  public static void main(String args[]) { 
    Stack s = new Stack();
    Bird borb = new Bird("Finch");
    s.push(borb);
    s.push(borb);
    s.push(borb);
    s.push(borb);
    borb = new Bird("BlueBird");
    s.push(borb);
    System.out.println(s.peek());
    System.out.println(s.find("Finch"));
  } 
}