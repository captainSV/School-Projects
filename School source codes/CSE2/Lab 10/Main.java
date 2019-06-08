import java.io.*;
import java.util.Scanner;

class Main {
  public static String TimeConverter(String[] a){
    int hour = Integer.parseInt(a[0]) % 12;
    int minute = Integer.parseInt(a[1]);
    String offset = "";
    if(Integer.parseInt(a[0]) < 11){
      offset = "AM";
    }else{
      offset = "PM";
    }
    return ("" + hour + ":" + minute + " " + offset);
  }
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    System.out.println("What's the time? Enter \"End\" to end... ");
    String str = scan.nextLine();
    while(str != "End"){
      try{
        String [] arrOfStr = str.split(":");
        if(Integer.parseInt(arrOfStr[0]) < 0 || Integer.parseInt(arrOfStr[0]) > 23) {
          throw new TimeFormatException(str); 
        }else if(Integer.parseInt(arrOfStr[1]) < 0 || Integer.parseInt(arrOfStr[1]) > 59){
          throw new TimeFormatException(str); 
        }else{
          System.out.println("This is the same as: " + TimeConverter  (arrOfStr));
        }
      }catch(TimeFormatException | NumberFormatException a){
        System.out.println("There is no such time as " + str);
      }
    }
  }
}
class TimeFormatException extends Exception{
  public TimeFormatException(String a){
    super(a);
  }
}