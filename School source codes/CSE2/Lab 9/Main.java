class Main { 
  public static void main(String args[]) { 
    Stack s = new Stack();
    Cloth shirt = new Cloth("Shirt", "Blue", false);
    s.push(shirt);
    Cloth shirt1 = new Cloth("Dress", "Blue", false);
    s.push(shirt1);
    Cloth shirt2 = new Cloth("Shirt", "white", true);
    s.push(shirt2);
    Cloth shirt3 = new Cloth("Skirt", "yellow", false);
    s.push(shirt3);
    Cloth shirt4 = new Cloth("Wifebeater", "grey", true);
    s.push(shirt4);
    System.out.println(s.peek());
    System.out.println(s.allColor("BLUE"));
    System.out.println(s.pop() + " Popped from stack");
    System.out.println(s.howManyTemp());
    System.out.println("\n\n\n\n");

    Que q = new Que();
    q.enque(new Food("Pasgheti",200,1));
    q.enque(new Food("Spaghetti",400,1));
    q.enque(new Food("Borger",800,2));
    q.enque(new Food("Pizza",450,3));
    q.enque(new Food("Pasgheti",200,1));
    q.deque();
    System.out.println(q.peek());
    System.out.println(q.avgCal());
    System.out.println(q.highestCal());
  } 
}