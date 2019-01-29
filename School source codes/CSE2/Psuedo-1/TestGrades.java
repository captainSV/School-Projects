
//Sasha Angermueller
//CSE1322 Lab Section 06
import java.io.*;
import java.util.Scanner;
import java.util.Arrays;
import java.util.ArrayList;

class Student{
  
  private String studentName;
  private String lastName;
  private int[] grades;
  private double average;
  private char letterGrade = 'z';
  
  public Student(String first, String last, int[] grade){
    studentName = first;
    lastName = last;
    grades = grade;
    double temp = 0;
    for(int i = 0; i < 5; i++){
      temp += grade[i];
    }
    average = temp/5;
    if (average >= 90) {
      letterGrade = 'A';
    } else if (average >= 80) {
      letterGrade = 'B';
    } else if (average >= 70) {
      letterGrade = 'C';
    } else if (average >= 60) {
      letterGrade = 'D';
    } else {
      letterGrade = 'F';
    }
  }
  public String getName(){
    return studentName;
  }
  public String getLastName(){
    return lastName;
  }
  public int[] getGrades(){
    return grades;
  }
  public double getAverage(){
    return average;
  }
  //First argument is which grade to change, second arguement is what to change it to
  public void setGrade(int i, int grade){
    grades[i] = grade;
  }
  public String toString(){
    return("" + String.format("%-8s", studentName) + String.format("%5s", lastName) + String.format("%5s", grades[0]) + String.format("%5s", grades[1]) + String.format("%5s", grades[2]) + String.format("%5s", grades[3]) + String.format("%5s", grades[4]) + String.format("%5s", average) + String.format("%5s", letterGrade) + "\n");
  }
}

class TestGrades {
  public static void main(String[] args) {
    int[] data = new int[5];
    double classAverage = 0;
    ArrayList<Student> students = new ArrayList<Student>();
    Scanner scan = new Scanner(System.in);
    int counter = 0;
    while (counter == 0) {
      System.out.println("What is the students first name?");
      String firstName = scan.nextLine();
      System.out.println("What is the students last name?");
      String lastName = scan.nextLine();
      System.out.println("What are the students 5 grades?");
      data[0]  = Integer.parseInt(scan.nextLine());
      data[1]  = Integer.parseInt(scan.nextLine());
      data[2]  = Integer.parseInt(scan.nextLine());
      data[3]  = Integer.parseInt(scan.nextLine());
      data[4]  = Integer.parseInt(scan.nextLine());
      students.add(new Student(firstName, lastName, data));
      System.out.println("Press 0 if you would like to input another student, or any other number to exit.");
      counter = Integer.parseInt(scan.nextLine());
    }
    System.out.println("" + String.format("%-8s", "First") + String.format("%5s", "Last") + String.format("%5s", "Test 1") + String.format("%5s", "Test 2") + String.format("%5s", "Test 3") + String.format("%5s", "Test 4") + String.format("%5s", "Test 5") + String.format("%5s", "average") + String.format("%5s", "Grade") + "\n");
    for(int i = 0; i < students.size(); i++){
      System.out.println(students.get(i).toString());
    }
    for(int i = 0; i < students.size(); i++){
      classAverage = classAverage + students.get(i).getAverage();
    }
    System.out.println("Class Average = " + (classAverage/students.size()));
  }
}