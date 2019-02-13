public class Octagon extends GeometricObject{

  public double sideLength;

  public Octagon(double side){
    sideLength = side;
  }
  public double getArea(){
    return (2+(4/(Math.sqrt(2)))*Math.pow(sideLength,2));
  }
  public double getSideLength(){
      return sideLength;
  }
  public double getPerimeter(){
    return (sideLength*8);
  }
  @Override
  public int compareTo(GeometricObject other){
    int otherSideLength  = (int)((Octagon)other).getSideLength();
    return ((int)sideLength - otherSideLength);
  }
  @Override
  public Object clone(){
    Octagon temp = new Octagon(this.sideLength);
    return temp;
  }
}