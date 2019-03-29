class Bird{
  public String type;
  public int amount;

  public Bird(String a){
    type = a;
    amount = 1;
  }

  public String toString(){
    return "" + type + ": " + amount;
  }
}