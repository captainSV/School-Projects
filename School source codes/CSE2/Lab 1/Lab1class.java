
//Sasha Angermueller
//CSE1322 Lab Section 06
import java.io.*;
import java.util.Scanner;

class Lab1class {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    System.out.println("What is your name?");
    String UserName = scan.nextLine();
    System.out.println("What is your age?");
    String UserAge = scan.nextLine();
    System.out.println("Your name is " + UserName + " and your age is " + UserAge);
  }
}