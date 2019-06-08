import java.io.*;
import java.util.Scanner;

class Main {
  public static void main(String[] args) {
    Scanner scaner = new Scanner(System.in);
    String yeet = "";
    boolean yeett = true;
    System.out.println("What file to copy from?");
    while(yeett){
      try{
        Scanner scan = new Scanner(new File(scaner.nextLine().toString()));
          while(scan.hasNextLine()) {
            yeet += scan.nextLine();
          }
          break;
        }catch(Exception t){
          System.out.println("That's not a findable file! Would you like to try again?");
        }
      }
      System.out.println("What file to copy to?");
      String yeetyeet = scaner.nextLine().toString();
    try (PrintStream out = new PrintStream(new FileOutputStream(yeetyeet))){
      out.print(yeet);
    }catch(Exception m){
      System.out.println("Something went wrong");
    }
  }
}