//Sasha Angermueller
//CSE1322 Lab Section 06
public class Faculty extends Employee{

  public String officeHours;
  public String rank;

  public Faculty(String nme, String addr, String phone, String email, String office, int Salary, String hired, String hours, String rank){
    super(nme, addr, phone, email, office, Salary, hired);
    officeHours = hours;
    this.rank = rank;
  }
  public String toString(){
    return "Faculty: " + name;
  }
}