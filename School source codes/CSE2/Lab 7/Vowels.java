class Vowels {
  public static void main(String[] args) {
    System.out.println(Vowels("twelve", 0));
  }
  public static int Vowels(String test, int a){
    char b = test.charAt(0);
    if (b == 'a' || b == 'e' || b == 'i' || b == 'o' || b == 'u' || b == 'y' || b == 'A' || b == 'E' || b == 'I' || b == 'O' || b == 'U' || b == 'Y'){
      a++;
    }
    if(test.length() == 1)
      return a;
    else
      return Vowels(test.substring(1),a);
  }
}