class Cloth{
  public String name;
  public String color;
  public boolean wash;

  public Cloth(String a, String b, boolean c){
    name = a;
    color = b;
    wash = c;
  }

  public String toString(){
    return color + " " + name;
  }
}