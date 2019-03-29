public class SVArrList{
  int[] myClassArray;

  public SVArrList(){
    myClassArray = new int[20];
  }
  public SVArrList(int a){
    myClassArray = new int[a];
  }

  public void add(int number){
    int i = 0;
    while(myClassArray[i] != 0){
      i++;
    }
    myClassArray[i] = number;
  }

  public int get(int a){
    return myClassArray[a];
  }

  public int size(){
    int i = 0;
    while(myClassArray[i] != 0){
      i++;
    }
    return i;
  }

  public String list(){
    int i = 0;
    String yeet = "";
    while(myClassArray[i] != 0){
      yeet += myClassArray[i] + ", ";
      i++;
    }
    return yeet.substring(0,yeet.length()-2);
  }
}