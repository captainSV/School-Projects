//Sasha Angermueller
//CSE1322 Lab Section 06
public class Person{

  public String name;
  public String address;
  public String phoneNumber;
  public String emailAddress;

  public Person(String nme, String addr, String phone, String email){
    name = nme;
    address = addr;
    phoneNumber = phone;
    emailAddress = email;
  }
  public String getName(){
    return name;
  }
  public String getAddress(){
    return address;
  }
  public String getPhone(){
    return phoneNumber;
  }
  public String getEmail(){
    return emailAddress;
  }
  public String toString(){
    return String.format("Person: %s, address: %s, Phone: %s, Email: %s",name,address,phoneNumber,emailAddress);
  }
}