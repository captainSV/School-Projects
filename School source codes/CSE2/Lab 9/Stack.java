class Stack { 
  public int top; 
  public Cloth a[] = new Cloth[20];
  public int MAX = 20;
 
  public boolean isEmpty() { 
    return (top < 0); 
  } 

  public Stack() { 
    top = -1; 
  } 
 
  public boolean push(Cloth x) { 
    if (top >= (MAX-1)) { 
      System.out.println("Push: Stack Overflow"); 
      return false; 
    }else{ 
      a[++top] = x; 
      //System.out.println(x + " pushed into stack"); 
      return true; 
    } 
  }

  public String pop() { 
    if (top < 0) { 
      System.out.println("Pop: Stack Underflow"); 
      return ""; 
    }else{ 
      Cloth x = a[top--];
      return x.color + " " + x.name; 
    } 
  }

  public String peek(){
    if (top < 0) { 
      System.out.println("Peek: Stack Underflow"); 
      return ""; 
    }else{
      return "" + a[top];
    }
  }

  public String allColor(String x){
    String y = "";
    for(int i = 0; i <= top; i++){
      if(a[i].color.toLowerCase().equals(x.toLowerCase())){
        y += "" + a[i] + ", ";
      }
    }
    return y;
  }

  public int howManyTemp(){
    int y = 0;
    for(int i = 0; i <= top + 1; i++){
      if(a[i].wash){
        y++;
      }
    }
    return y;
  }
}