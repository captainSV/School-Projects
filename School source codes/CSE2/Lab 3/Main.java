
//Sasha Angermueller
//CSE1322 Lab Section 06

class Main {  
  public static void main(String[] args) {
    Person myPerson = new Person("Sasha", "121 Star Chase Ln", "7706860839", "cyk4bly4tt@gmail.com");
    Student myStudent = new Student("Valeria", "121 Star Chase Ln", "7706860839", "cyk4bly4tt@gmail.com", "Freshman");
    Employee myEmployee = new Employee("Joseph", "121 Star Chase Ln", "7706860839", "cyk4bly4tt@gmail.com", "HV111", 120000, "05/23/2018");
    Staff myStaff = new Staff("Klaus", "121 Star Chase Ln", "7706860839", "cyk4bly4tt@gmail.com", "HV111", 120000, "05/23/2018", "Dutchess");
    Faculty myFaculty = new Faculty("Ari", "121 Star Chase Ln", "7706860839", "cyk4bly4tt@gmail.com", "HV111", 120000, "05/23/2018", "1100-2000", "Dutchess");
    System.out.println(myPerson);
    System.out.println(myStudent);
    System.out.println(myEmployee);
    System.out.println(myStaff);
    System.out.println(myFaculty);
  }
}