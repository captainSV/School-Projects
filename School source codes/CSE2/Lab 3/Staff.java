//Sasha Angermueller
//CSE1322 Lab Section 06
public class Staff extends Employee{

  public String title;

  public Staff(String nme, String addr, String phone, String email, String office, int Salary, String hired, String title){
    super(nme, addr, phone, email, office, Salary, hired);
    this.title = title;
  }
  public String toString(){
    return String.format("Faculty: %s, address: %s, Phone: %s, Email: %s, Office: %s, Title: %s, Salary: %s, Date of Hire: %s",name,address,phoneNumber,emailAddress,office,title,salary,dateHired);
  }
}