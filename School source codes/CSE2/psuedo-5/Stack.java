class Stack { 
  public int top; 
  public Bird a[] = new Bird[20];
  public int MAX = 20;
 
  public boolean isEmpty() { 
    return (top < 0); 
  } 

  public Stack() { 
    top = -1; 
  } 
 
  public boolean push(Bird x) { 
    if (top >= (MAX-1)) { 
      System.out.println("Push: Stack Overflow"); 
      return false; 
    }else{
      boolean isntIn = true;
      for(int i = 0; i <= top; i++){
        if(a[i].type.toLowerCase().equals(x.type.toLowerCase())){
          a[i].amount += 1;
          isntIn = false;
        }
      }
      if(isntIn){
        top++;
        a[top] = x;
      }  
      return true; 
    } 
  }

  public String pop() { 
    if (top < 0) { 
      System.out.println("Pop: Stack Underflow"); 
      return ""; 
    }else{ 
      Bird x = a[top--];
      return x.toString(); 
    } 
  }

  public String peek(){
    if (top < 0) { 
      System.out.println("Peek: Stack Underflow"); 
      return ""; 
    }else{
      return a[top].toString();
    }
  }

  public String find(String x){
    for(int i = 0; i <= top + 1; i++){
      if(a[i].type.toLowerCase().equals(x.toLowerCase())){
        return a[i].toString();
      }
    }
    return "Couldn't find that bird, sorry.";
  }
}