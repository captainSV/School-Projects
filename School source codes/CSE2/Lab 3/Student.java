//Sasha Angermueller
//CSE1322 Lab Section 06
public class Student extends Person{

  public String classStatus;

  public Student(String nme, String addr, String phone, String email, String cStatus){
    super(nme, addr, phone, email);
    classStatus = cStatus;
  }
  public String toString(){
    return "Student: " + name;
  }
}