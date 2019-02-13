
//Sasha Angermueller
//CSE1322 Lab Section 06

class Main {
  public static void main(String[] args) {
    Octagon test = new Octagon(8);
    System.out.println(test.getArea());
    System.out.println(test.getPerimeter());
    Octagon newTest = (Octagon) test.clone();
    if(test.compareTo(newTest) == 0){
      System.out.println("The Octagons are equel in side length");
    }else{
      System.out.println("The Octagons are not equel in side length");
    }
  }
}