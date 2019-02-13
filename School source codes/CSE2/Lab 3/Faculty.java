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
    return String.format("Faculty: %s, address: %s, Phone: %s, Email: %s, Office: %s, Office Hours: %s, Rank: %s, Salary: %s, Date of Hire: %s",name,address,phoneNumber,emailAddress,office,officeHours,rank,salary,dateHired);
  }
}