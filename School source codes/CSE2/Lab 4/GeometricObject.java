public abstract class GeometricObject implements Comparable<GeometricObject>, Cloneable{

  public abstract int compareTo(GeometricObject otherGeometricObject);
  public abstract Object clone();
}