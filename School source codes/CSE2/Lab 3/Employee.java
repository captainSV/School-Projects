//Sasha Angermueller
//CSE1322 Lab Section 06
public class Employee extends Person{

  public String office;
  public int salary;
  public String dateHired;

  public Employee(String nme, String addr, String phone, String email, String office, int Salary, String hired){
    super(nme, addr, phone, email);
    this.office = office;
    salary = Salary;
    dateHired = hired;
  }
  public String toString(){
    return String.format("Employee: %s, address: %s, Phone: %s, Email: %s, Office: %s, Salary: %s, Date of Hire: %s",name,address,phoneNumber,emailAddress,office,salary,dateHired);
  }
}