class Palindrome {
  public static void main(String[] args){
    System.out.println(palindromeTesting("YEETyeTEEY"));
  }
  public static boolean palindromeTesting(String test){
    if (test.length() == 0 || test.length() == 1){
      return true;
    }
    char a = test.charAt(0);
    char b = test.charAt(test.length()-1);
    if(a == b){
      return palindromeTesting(test.substring(1,test.length()-1));
    }else{
      return false;
    }
  }
}